using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Services;

namespace App.Services
{
    class Controller
    {
        public bool has = false;
        string message = string.Empty;
        public bool acess(string login, string senha) {

            Command command = new Command();
            has = command.verifylogin(login, senha);
            if (string.IsNullOrEmpty(command.message)) {
                message = command.message;
            }
            return has;
        }

        public string register(string login, string senha) {
            return message;
        }
    }
}
