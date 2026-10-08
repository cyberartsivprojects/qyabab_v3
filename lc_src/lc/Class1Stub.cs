using System;
using System.Windows.Forms;

namespace ns0
{
    internal static class Class1
    {
        private static Class0 _class0;
        private static Form0 _form0;
        private static MyForms _myForms;

        public static Class0 Class0_0
        {
            get
            {
                if (_class0 == null) _class0 = new Class0();
                return _class0;
            }
        }

        public static Form0 Form0_0
        {
            get
            {
                if (_form0 == null) _form0 = new Form0();
                return _form0;
            }
        }

        public static MyForms MyForms_0
        {
            get
            {
                if (_myForms == null) _myForms = new MyForms();
                return _myForms;
            }
        }

        internal class MyForms
        {
            private main _loader;
            private gui _program;
            private GForm0 _empty;

            public main loader
            {
                get
                {
                    if (_loader == null || _loader.IsDisposed) _loader = new main();
                    return _loader;
                }
            }

            public gui _o_program
            {
                get
                {
                    if (_program == null || _program.IsDisposed) _program = new gui();
                    return _program;
                }
            }

            public GForm0 empty
            {
                get
                {
                    if (_empty == null || _empty.IsDisposed) _empty = new GForm0();
                    return _empty;
                }
            }
        }
    }
}