global using System;
global using System.Collections.Generic;
global using System.Threading;
global using System.Threading.Tasks;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Fast.Components.FluentUI;
global using Testcontainers.SqlEdge;
global using WeatherForecast;
global using WeatherForecast.Contexts;
global using WeatherForecast.Entities;
global using WeatherForecast.Interactors;
global using WeatherForecast.Interactors.SearchCityOrZipCode;
global using WeatherForecast.Repositories;
