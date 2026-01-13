using Microsoft.Extensions.DependencyInjection;
using QuizBattle.Console.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizBattle.Console.Extensions
{
    public static class ConsolePresentationExtensions
    {
        public static IServiceCollection AddConsolePresentation(this IServiceCollection services)
        {
            services.AddSingleton<IConsoleQuestionPresenter, ConsoleQuestionPresenter>();

            return services;
        }
    }
}
