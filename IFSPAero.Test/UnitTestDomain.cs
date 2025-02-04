using IFSPAero.Domain.Entities;
using System.Diagnostics;
using System.Text.Json;

namespace IFSPAero.Test
{
    [TestClass]
    public class UnitTestDomain
    {
        public Aeroporto RetornaAeroporto()
        {
            Aeroporto aeroporto = new Aeroporto(1, "Deputado Freitas Nobre", "CGH", "Congonhas", "Brasil");
            return aeroporto;
        }
        public Companhia RetornaCompanhia()
        {
            Companhia companhia = new Companhia(1, "Azul");
            return companhia;
        }

        public Hangar RetornaHangar()
        {
            Aeroporto aeroporto = RetornaAeroporto();
            Hangar hangar = new Hangar(1, "B4", aeroporto);

            return hangar;
        }
        public Aviao RetornaAviao()
        {
            Companhia companhia = RetornaCompanhia();
            UInt32 fileSize;
            byte[] byteImage;
            FileStream fs;
            
            
            fs = new FileStream("/home/cairim/Downloads/IFSPAero/IFSPAero.Test/TestImage/A320.jpg", FileMode.Open, FileAccess.Read);
            fileSize = (uint)fs.Length;
            byteImage = new byte[fileSize];
            fs.ReadExactly(byteImage, 0, (int)fileSize);
            
            
            Aviao aviao = new Aviao(1, "Airbus A320", 1, "AX111", byteImage, companhia);
            return aviao;
        }
        [TestMethod]
        public void TestAeroporto()
        {
            Aeroporto aeroporto = new Aeroporto(1, "Deputado Freitas Nobre", "CGH", "Congonhas", "Brasil");
            
            Debug.WriteLine(JsonSerializer.Serialize(aeroporto));
            
            Assert.AreEqual(aeroporto.Nome, "Deputado Freitas Nobre");
            Assert.AreEqual(aeroporto.Codigo, "CGH");
            Assert.AreEqual(aeroporto.Cidade, "Congonhas");
            Assert.AreEqual(aeroporto.Pais, "Brasil");
            
        }

        [TestMethod]
        public void Hangar()
        {
            Aeroporto aeroporto = RetornaAeroporto();
            Hangar hangar = new Hangar(1, "B4", aeroporto);
            
            Debug.WriteLine(JsonSerializer.Serialize(hangar));
            Assert.AreEqual(hangar.Codigo, "B4");
            Assert.AreEqual(hangar.Aeroporto, aeroporto);
        }
        
        [TestMethod]
        public void TestCompanhia()
        {
            Companhia companhia = new Companhia(1, "Azul");
            
            Debug.WriteLine(JsonSerializer.Serialize(companhia));
            Assert.AreEqual(companhia.Nome, "Azul");
        }

        [TestMethod]
        public void TestAviao()
        {
            Companhia companhia = RetornaCompanhia();
            UInt32 fileSize;
            byte[] byteImage;
            FileStream fs;
            
            
            fs = new FileStream("/home/cairim/Downloads/IFSPAero/IFSPAero.Test/TestImage/A320.jpg", FileMode.Open, FileAccess.Read);
            fileSize = (uint)fs.Length;
            byteImage = new byte[fileSize];
            fs.ReadExactly(byteImage, 0, (int)fileSize);
            
            
            Aviao aviao = new Aviao(1, "Airbus A320", 1, "AX111", byteImage, companhia);
            Debug.WriteLine(JsonSerializer.Serialize(aviao));
            Assert.AreEqual(aviao.Modelo, "Airbus A320");
            Assert.AreEqual(aviao.Situacao, 1);
            Assert.AreEqual(aviao.Codigo, "AX111");
            Assert.AreEqual(aviao.Imagem, byteImage);
            Assert.AreEqual(aviao.Companhia, companhia);
            
        }

        [TestMethod]
        public void AviaoEstacionado()
        {
            Aviao aviao = RetornaAviao();
            Hangar hangar = RetornaHangar();
            DateTime dateNow = DateTime.Now;
            DateTime dateValue = new DateTime(2055, 12, 20, 21, 30, 00);
            TimeSpan duracao = dateValue.Subtract(dateNow);
            AviaoEstacionado aviaoEstacionado = new AviaoEstacionado(1, aviao, hangar, dateNow, duracao.ToString(), dateValue);
            
            Debug.WriteLine(JsonSerializer.Serialize(aviaoEstacionado));
            
            Assert.AreEqual(aviaoEstacionado.Aviao, aviao);
            Assert.AreEqual(aviaoEstacionado.Hangar, hangar);
            Assert.AreEqual(aviaoEstacionado.ComecoEstacionamento, dateNow);
            Assert.AreEqual(aviaoEstacionado.DuracaoEstacionamento, duracao.ToString());
            Assert.AreEqual(aviaoEstacionado.FimEstacionamento, dateValue);
        }
    }
    
}

