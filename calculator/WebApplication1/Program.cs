using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;

using CalculatorApp;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "�����������:\n" + 
                     "/add/{x}/{y} - ��������\n" +
                     "/subtract/{x}/{y} - ���������\n" +
                     "/multiply/{x}/{y} - ���������\n" +
                     "/divide/{x}/{y} - �������\n" +
                     "/power/{x}/{y} - ���������� � �������\n\n" +
                     "������: /add/5/3");

app.MapGet("/add/{x}/{y}", (decimal x, decimal y) =>
{
    var result = Calculator.Add(x, y);
    return Results.Text($"{x} + {y} = {result}");
});

app.MapGet("/subtract/{x}/{y}", (decimal x, decimal y) =>
{
    var result = Calculator.Subtract(x, y);
    return Results.Text($"{x} - {y} = {result}");
});

app.MapGet("/multiply/{x}/{y}", (decimal x, decimal y) =>
{
    var result = Calculator.Multiply(x, y);
    return Results.Text($"{x} * {y} = {result}");
});

app.MapGet("/divide/{x}/{y}", (decimal x, decimal y) =>
{
    try
    {
        var result = Calculator.Divide(x, y);
        return Results.Text($"{x} / {y} = {result}");
    }
    catch (DivideByZeroException ex)
    {

        return Results.Text($"������: {ex.Message}", statusCode: StatusCodes.Status400BadRequest);
    }
});

app.MapGet("/power/{x}/{y}", (decimal x, decimal y) =>
{
    try
    {
        var result = Calculator.Power(x, y);
        return Results.Text($"{x} ^ {y} = {result}");
    }
    catch (ArgumentException ex)
    {

        return Results.Text($"������: {ex.Message}", statusCode: StatusCodes.Status400BadRequest);
    }
});

app.Run();

namespace CalculatorApp 
{
    public static class Calculator
    {
        public static decimal Add(decimal x, decimal y) => x + y;
        public static decimal Subtract(decimal x, decimal y) => x - y;
        public static decimal Multiply(decimal x, decimal y) => x * y;

        public static decimal Divide(decimal x, decimal y)
        {
            if (y == 0) throw new DivideByZeroException("������� �� ���� ����������!");
            return x / y;
        }

        public static decimal Power(decimal x, decimal y)
        {
            if (y == 0) return 1;
            if (x == 0 && y > 0) return 0;
            if (x == 0 && y < 0) throw new ArgumentException("���� � ������������� ������� �� ���������!");
            return (decimal)Math.Pow((double)x, (double)y);
        }
    }
}
