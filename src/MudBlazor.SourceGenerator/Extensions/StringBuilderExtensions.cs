// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MudBlazor.SourceGenerator.Extensions;

internal static class StringBuilderExtensions
{
    public static StringBuilder AppendCode(this StringBuilder builder, string value, ushort indent = 0)
    {
        for (var i = 0; i < indent; i++)
        {
            builder.Append("    ");
        }

        return builder.AppendLine(value);
    }
    // Improves development experience by allowing appending multiple lines of code with a specified indentation.
    public static StringBuilder AppendCodeLines(this StringBuilder builder, IEnumerable<string> lines, ushort indent = 0)
    {
        var indentString = new string(' ', indent * 4);
        foreach (var line in lines)
        {
            builder.AppendLine($"{indentString}{line}");
        }
        return builder;
    }
    
}
