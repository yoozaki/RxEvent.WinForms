using System.IO;

namespace RxEvent.WinForms.Generator
{
    class Program
    {
        static void Main()
        {
            File.WriteAllText(
                    @"..\..\..\RxEvent.WinForms\RxEvent.cs", 
                    new EventAsObservable().TransformText());
        }
    }
}
