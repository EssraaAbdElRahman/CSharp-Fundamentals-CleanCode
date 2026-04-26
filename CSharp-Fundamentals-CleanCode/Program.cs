using CSharp_Fundamentals_CleanCode.Core;
using CSharp_Fundamentals_CleanCode.Services;
using CSharp_Fundamentals_CleanCode.Tasks.Basics;

var input = new InputService();
var output = new OutputService();

ITask task = new EvenOddTask(input, output);

task.Execute();