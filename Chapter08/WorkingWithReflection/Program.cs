﻿using static System.Console;
using System.Reflection;
using System.Runtime.CompilerServices;
using WorkingWithReflection;

WriteLine("Assembly metadata:");
Assembly? assembly = Assembly.GetEntryAssembly();
if (assembly is null)
{
    WriteLine("Failed to get entry assembly.");
    return;
}
WriteLine($"  Full name: {assembly.FullName}");
WriteLine($"  Location: {assembly.Location}");
IEnumerable<Attribute> attributes = assembly.GetCustomAttributes();
WriteLine($"  Assembly-level attributes:");
foreach (Attribute a in attributes)
{
    WriteLine($"    {a.GetType()}");
}

AssemblyInformationalVersionAttribute? version = assembly
    .GetCustomAttribute<AssemblyInformationalVersionAttribute>(); 
WriteLine($"  Version: {version?.InformationalVersion}");
AssemblyCompanyAttribute? company = assembly
    .GetCustomAttribute<AssemblyCompanyAttribute>();
WriteLine($"  Company: {company?.Company}");

WriteLine(); 
WriteLine($"* Types:");
Type[] types = assembly.GetTypes();
foreach (Type type in types)
{
    WriteLine();
    WriteLine($"Type: {type.FullName}"); 
    MemberInfo[] members = type.GetMembers();
    foreach (MemberInfo member in members)
    {
        WriteLine("{0}: {1} ({2})",
            arg0: member.MemberType,
            arg1: member.Name,
            arg2: member.DeclaringType?.Name);
        IOrderedEnumerable<CoderAttribute> coders = 
            member.GetCustomAttributes<CoderAttribute>()
                .OrderByDescending(c => c.LastModified);
        foreach (CoderAttribute coder in coders)
        {
            WriteLine("-> Modified by {0} on {1}",
                coder.Coder, coder.LastModified.ToShortDateString());
        }
    }
}

class Animal
{
    [Coder("Thomas Henley", "14 December 2022")]
    [Coder("Emily Cox", "15 December 2022")]
    public void Speak()
    {
        WriteLine("Woof...");
    }
}