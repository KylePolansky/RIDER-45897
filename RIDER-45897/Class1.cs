using System;

namespace RIDER_45897
{
    public class Class1
    {
        private class Foo
        {
            public string Bar { get; set; }
        }

        public void Sample1()
        {
            // Correct according to .editorconfig
            var foo = new Foo {
                Bar = "Bar"
            };

            // RIDER 2020.2 EAP suggests this fix, which causes a build error
            // var foo = new Foo
            // {
            //     Bar = "Bar"
            // };
        }

        public void Sample2()
        {
            // Correct according to .editorconfig
            Func<string> foo = () => {
                return "bar";
            };

            // RIDER 2020.2 EAP suggests this fix, which causes a build error
            // Func<string> foo = () =>
            // {
            //     return "bar";
            // };
        }
    }
}