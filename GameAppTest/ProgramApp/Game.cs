using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramApp
{
    class Game
    {
     
        private Option _option;
        private Button _settings;
        private Button _exit;

        public Option Option
        {
            get
            {
                return _option;
            }
            set
            {
                _option = value;
            }
        }
        public Button Settings
        {
            get
            {
                return _settings;
            }
            set
            {
                _settings = value;
            }
        }
        public Button Exit
        {
            get
            {
                return _exit;
            }
            set
            {
                _exit = value;
            }
        }

        public void start_new()
        {

        }

        public void load()
        {

        }
        public void settings()
        {

        }
        public void exit()
        {

        }

    }
}
