using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using IFSPAero.Domain.Base;
using IFSPAero.Domain.Entities;
using IFSPAero.Repository.Context;
using IFSPAero.Repository.Repository;
using IFSPAero.Services.Services;
using IFSPAero.App.Forms;
using IFSPAero.App.Models;
using AutoMapper;

namespace IFSPAero.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;
        public static IServiceProvider? ServicesProvider;

        public static void ConfigureServices()
        {
            Services = new ServiceCollection();
            var strCon = File.ReadAllText("Config/ConfigBanco.txt");
            Services.AddDbContext<MySqlContext>(option =>
            {
                option.LogTo(Console.WriteLine).EnableSensitiveDataLogging();
                option.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure();
                });
            });
            Services.AddScoped<IBaseRepository<Aeroporto>, BaseRepository<Aeroporto>>();
            Services.AddScoped<IBaseRepository<Aviao>, BaseRepository<Aviao>>();
            Services.AddScoped<IBaseRepository<AviaoEstacionado>, BaseRepository<AviaoEstacionado>>();
            Services.AddScoped<IBaseRepository<Companhia>, BaseRepository<Companhia>>();
            Services.AddScoped<IBaseRepository<Funcao>, BaseRepository<Funcao>>();
            Services.AddScoped<IBaseRepository<Funcionario>, BaseRepository<Funcionario>>();
            Services.AddScoped<IBaseRepository<Hangar>, BaseRepository<Hangar>>();
            Services.AddScoped<IBaseRepository<TipoVoo>, BaseRepository<TipoVoo>>();
            Services.AddScoped<IBaseRepository<Voo>, BaseRepository<Voo>>();

            Services.AddScoped<IBaseService<Aeroporto>, BaseService<Aeroporto>>();
            Services.AddScoped<IBaseService<Aviao>, BaseService<Aviao>>();
            Services.AddScoped<IBaseService<AviaoEstacionado>, BaseService<AviaoEstacionado>>();
            Services.AddScoped<IBaseService<Companhia>, BaseService<Companhia>>();
            Services.AddScoped<IBaseService<Funcao>, BaseService<Funcao>>();
            Services.AddScoped<IBaseService<Funcionario>, BaseService<Funcionario>>();
            Services.AddScoped<IBaseService<Hangar>, BaseService<Hangar>>();
            Services.AddScoped<IBaseService<TipoVoo>, BaseService<TipoVoo>>();
            Services.AddScoped<IBaseService<Voo>, BaseService<Voo>>();

            Services.AddTransient<CadastraAeroporto, CadastraAeroporto>();
            Services.AddTransient<CadastraAviao, CadastraAviao>();
            Services.AddTransient<CadastraAviaoEstacionado, CadastraAviaoEstacionado>();
            Services.AddTransient<CadastraCompanhia, CadastraCompanhia>();
            Services.AddTransient<CadastraFuncaoFuncionario, CadastraFuncaoFuncionario>();
            Services.AddTransient<CadastraFuncionario, CadastraFuncionario>();
            Services.AddTransient<CadastraHangar, CadastraHangar>();
            Services.AddTransient<CadastraTipoVoo, CadastraTipoVoo>();
            Services.AddTransient<CadastraVoo, CadastraVoo>();

            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Aeroporto, AeroportoModel>();
                config.CreateMap<TipoVoo, TipoVooModel>();
                config.CreateMap<Funcao, FuncaoModel>();
                config.CreateMap<Companhia, CompanhiaModel>();
                config.CreateMap<Aviao, AviaoModel>()
                    .ForMember(d => d.IdCompanhia, d => d.MapFrom(x => x.Companhia!.Id))
                    .ForMember(d => d.Companhia, d => d.MapFrom(x => x.Companhia!.Nome));
                config.CreateMap<Funcionario, FuncionarioModel>()
                    .ForMember(d => d.IdFuncao, d => d.MapFrom(x => x.Funcao!.Id))
                    .ForMember(d => d.Funcao, d => d.MapFrom(x => x.Funcao!.NomeFuncao))
                    .ForMember(d => d.IdCompanhia, d => d.MapFrom(x => x.Companhia!.Id))
                    .ForMember(d => d.Companhia, d => d.MapFrom(x => x.Companhia!.Nome));
                config.CreateMap<Hangar, HangarModel>()
                    .ForMember(d => d.IdAeroporto, d => d.MapFrom(x => x.Aeroporto!.Id))
                    .ForMember(d => d.Aeroporto, d => d.MapFrom(x => x.Aeroporto!.Nome));
                config.CreateMap<AviaoEstacionado, AviaoEstacionadoModel>()
                    .ForMember(d => d.IdHangar, d => d.MapFrom(x => x.Hangar!.Id))
                    .ForMember(d => d.CodigoHangar, d => d.MapFrom(x => x.Hangar!.Codigo))
                    .ForMember(d => d.IdAviao, d => d.MapFrom(x => x.Aviao!.Id))
                    .ForMember(d => d.CodigoAviao, d => d.MapFrom(x => x.Aviao!.Codigo));
                config.CreateMap<Voo, VooModel>()
                    .ForMember(d => d.IdTipoVoo, d => d.MapFrom(x => x.TipoVoo!.Id))
                    .ForMember(d => d.TipoVoo, d => d.MapFrom(x => x.TipoVoo!.Tipo))
                    .ForMember(d => d.IdAviao, d => d.MapFrom(x => x.Aviao!.Id))
                    .ForMember(d => d.CodigoAviao, d => d.MapFrom(x => x.Aviao!.Codigo))
                    .ForMember(d => d.IdAeroportoChegada, d => d.MapFrom(x => x.AeroportoChegada!.Id))
                    .ForMember(d => d.NomeAeroportoChegada, d => d.MapFrom(x => x.AeroportoChegada!.Nome))
                    .ForMember(d => d.IdAeroportoSaida, d => d.MapFrom(x => x.AeroportoSaida!.Id))
                    .ForMember(d => d.NomeAeroportoSaida, d => d.MapFrom(x => x.AeroportoSaida!.Nome))
                    .ForMember(d => d.IdCapitao, d => d.MapFrom(x => x.Capitao!.Id))
                    .ForMember(d => d.NomeCapitao, d => d.MapFrom(x => x.Capitao!.Nome));
            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }

        

    }
}
