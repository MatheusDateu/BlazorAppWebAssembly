using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppWebAssembly.Shared.Validations
{
    public class AutenticaUsuario
    {
        private static string? _Nome { get; set; }
        private static string? _Senha { get; set; }
        public AutenticaUsuario()
        {

        }
        public AutenticaUsuario(string nome, string senha)
        {
            if(_Nome.Equals(string.Empty))
                _Nome = nome;
            if(_Senha.Equals(string.Empty))
                _Senha = senha;
        }

        public static string NomeUsuarioDestaSessao()
        {
            return _Nome;
        }

        public bool SenhaValida(string usuario, string senha)
        {
            if (usuario.Equals(_Nome) && senha.Equals(_Senha))
                return true;

            return false;
        }
    }
}
