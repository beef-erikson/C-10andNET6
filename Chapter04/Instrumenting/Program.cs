// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using Microsoft.Extensions.Configuration;

// write to a text file in the project folder
Trace.Listeners.Add(new TextWriterTraceListener(
    File.CreateText(Path.Combine(Directory.GetCurrentDirectory(), "./logs/log.txt"))));

// text writer is buffered, so this option calls 
// Flush() on all listeners after writing
Trace.AutoFlush = true;

Debug.WriteLine("Debug says, I am watching!");
Trace.WriteLine("Trace says, I am watching!");

// demonstrates setting different trace levels.
// looks for appsettings.json, builds the configuration, create a trace switch,
// sets its level by binding to the configuration, and then outputs the four trace switch levels.
ConfigurationBuilder builder = new();

builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(
    "appsettings.json",
    optional: true, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();

TraceSwitch ts = new(
    displayName: "PacktSwitch",
    description: "This switch is set via a JSON config.");

configuration.GetSection("PacktSwitch").Bind(ts); // point where ts levels are set

Trace.WriteLineIf(ts.TraceError, "Trace error");
Trace.WriteLineIf(ts.TraceWarning, "Trace warning");
Trace.WriteLineIf(ts.TraceInfo, "Trace info");
Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");
