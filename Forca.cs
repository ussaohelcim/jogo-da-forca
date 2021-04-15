using System;
namespace jogo_da_forca
{
    public class Forca
    {
        bool perdeu, ganhou;
        Random random;
        int erros;
        string [] palavras = {"teste","sei la","maca"};
        string palavraSelecionada;
        char [] letrasAcertadas;

        public void CLS() => Console.Clear();
        public void Inicio()
        {
            random = new Random();
            erros = 0;
            palavraSelecionada = palavras[random.Next(palavras.Length)];
            letrasAcertadas = new char[palavraSelecionada.Length];

            for (int i = 0; i < palavraSelecionada.Length; i++)
            {
                letrasAcertadas[i] = '*';
            }
            CLS();
            Console.WriteLine("Bem vindo ao jogo da forca feito por Michel Sousa!\nSorteei uma palavra e você deve descobrir qual é. Boa sorte!\nAperte uma tecla para continuar: ");
            Console.ReadKey();
            NovaRodada();
        }
        public void NovaRodada()
        {
            Console.WriteLine(letrasAcertadas+" "+ palavraSelecionada.ToCharArray());
            Console.WriteLine(DesenharForca());
            if(ChecarSePerdeu())
            {
                GameOver();
                Console.WriteLine(DesenharForca());
            } 
            else if(ChecarSeGanhou()) Winner();
            else
            {
                CLS();
                Console.WriteLine(DesenharForca());
                Console.WriteLine("Digite seu chute: ");
                if(!ChecarLetra(LerLetra()))
                {
                    erros++;
                }
                NovaRodada();
            }

        }
        void GameOver()
        {
            CLS();
            Console.WriteLine("Parabens, você perdeu! A palavra que escolhi foi: "+palavraSelecionada);
        }
        void Winner()
        {
            Console.WriteLine("Infelizmente você ganhou. ;-;");
        }
        bool ChecarSePerdeu() => erros >= 6 ? true : false;
        bool ChecarSeGanhou()
        {
            string a = new string(letrasAcertadas);
            string b = palavraSelecionada;
            return a == b ? true : false;
        } 
        public char LerLetra()
        {
            return Console.ReadLine()[0];
        }
        
        public string DesenharForca()
        {
            switch (erros)
            {
                case 0:
return @"
+-----------|
|           
|     	      
|    	   
|
+-----------------
|                       
"+PalavraForca();
                case 1:
return @"
+-----------|
|           O
|     	      
|    	   
|
+-----------------
|                       
"+PalavraForca();
                case 2:
return @"
+-----------|
|           O
|     	    |  
|    	   
|
+-----------------
|                       
"+PalavraForca();
                case 3:
return @"
+-----------|
|           O
|     	 /  |  
|    	   
|
+-----------------
|                       
"+PalavraForca();
                case 4:
return @"
+-----------|
|           O
|     	 /  |  \
|    	   
|
+-----------------
|                       
"+PalavraForca();
                case 5:
return @"
+-----------|
|           O
|     	 /  |  \
|    	   /
|
+-----------------
|                       
"+PalavraForca();
                case 6:
                return @"
+-----------|
|           O
|     	 /  |  \
|    	   /\
|
+-----------------
|                       
"+PalavraForca();
                default:
                return "deu pau";
                
            }
            
        }
        public string PalavraForca()
        {//retorna a palavra para a forca
            string a="";
            foreach (var item in letrasAcertadas)
            {
                a+=item;
            }
            return a;
        }
        public bool ChecarLetra(char letra)
        {
            bool acertouAlgo = false;
            for (int i = 0; i < palavraSelecionada.Length; i++)
            {
                if(letra == palavraSelecionada[i])
                {
                    letrasAcertadas[i] = palavraSelecionada[i];
                    if(!acertouAlgo) acertouAlgo = true;
                } 
            }
            return acertouAlgo;
        }
        public void ChecaPalavra()
        {
            
        }
    }
}