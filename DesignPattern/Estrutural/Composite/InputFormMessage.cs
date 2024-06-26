﻿namespace DesignPattern.Estrutural.Composite
{
    public class InputFormMessage : IMessage
    {
        public InputFormMessage(string name)
        {
            Nome = name;
        }

        public string Nome { get; set; }

        public void ExibirMensagens(int sub)
        {
            Console.WriteLine(new string('-', sub) + Nome);
        }
    }
}
