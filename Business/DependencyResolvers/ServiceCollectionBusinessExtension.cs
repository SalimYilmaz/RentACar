﻿using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Business.DependencyResolvers;

public static class ServiceCollectionBusinessExtension
{
    // Extension method
    // Metodun ve barındığı class'ın static olması gerekiyor
    // İlk parametere genişleteceğimiz tip olmalı ve başında this keyword'ü olmalı

    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
        services
            .AddSingleton<IBrandService, BrandManager>()
            .AddSingleton<IBrandDal, InMemoryBrandDal>()
            .AddSingleton<BrandBusinessRules>()

            .AddSingleton<IFuelService, FuelManager>()
            .AddSingleton<IFuelDal, InMemoryFuelDal>()
            .AddSingleton<FuelBusinessRules>()

            .AddSingleton<ITransmissionService, TransmissionManager>()
            .AddSingleton<ITransmissionDal, InMemoryTransmissionDal>()
            .AddSingleton<TransmissionBusinessRules>()

            .AddSingleton<IModelService, ModelManager>()
            .AddSingleton<IModelDal, InMemoryModelDal>()
            .AddSingleton<ModelBusinessRules>()  // Fluent

            .AddSingleton<ICarService, CarManager>()
            .AddSingleton<ICarDal, InMemoryCarDal>()
            .AddSingleton<CarBusinessRules>();

        services.AddAutoMapper(Assembly.GetExecutingAssembly());  // AutoMapper.Extensions.Microsoft.DependencyInjection NuGet Paketi
        // Reflection yöntemiyle Profile class'ını kalıtım alan tüm class'ları bulur ve AutoMapper'a ekler.

        return services;
    }
}