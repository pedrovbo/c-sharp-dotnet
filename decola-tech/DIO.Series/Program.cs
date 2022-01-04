using System;
using DIO.Filmes;
using DIO.Series.Classes;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorioSerie = new SerieRepositorio();
        static FilmeRepositorio repositorioFilme = new FilmeRepositorio();
        static void Main(string[] args)
        {
            string tipoCadastro = ObterTipoCadastro();
            
            if (tipoCadastro == "1")
            {
                string opcaoUsuarioSeries = ObterOpcaoUsuarioSeries();
                while (opcaoUsuarioSeries.ToUpper() != "X")
                {
                    switch (opcaoUsuarioSeries)
                    {
                        case "1":
                            ListarSeries();
                            break;
                        case "2":
                            InserirSerie();
                            break;
                        case "3":
                            AtualizarSerie();
                            break;
                        case "4":
                            ExcluirSerie();
                            break;
                        case "5":
                            VisualizarSerie();
                            break;
                        case "C":
                            Console.Clear();
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    opcaoUsuarioSeries = ObterOpcaoUsuarioSeries().ToUpper();
                } 
            }
            else if (tipoCadastro == "2")
            {
                string opcaoUsuarioFilmes = ObterOpcaoUsuarioFilmes();
                while (opcaoUsuarioFilmes.ToUpper() != "X")
                {
                    switch (opcaoUsuarioFilmes)
                    {
                        case "1":
                            ListarFilmes();
                            break;
                        case "2":
                            InserirFilmes();
                            break;
                        case "3":
                            //AtualizarFilmes();
                            break;
                        case "4":
                            //ExcluirFilmes();
                            break;
                        case "5":
                            //VisualizarFilmes();
                            break;
                        case "C":
                            Console.Clear();
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    opcaoUsuarioFilmes = ObterOpcaoUsuarioFilmes().ToUpper();
                }
            }

            else
            {
                Console.WriteLine("Valor inválido. Digite 1 para cadastro de Séries e 2 para cadastro de Filmes");
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        
        private static void ExcluirSerie()
        {
            Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorioSerie.Exclui(indiceSerie);
        }

        private static void VisualizarSerie()
        {
            Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorioSerie.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }

        private static void AtualizarSerie()
        {
            Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            ano: entradaAno,
                                            descricao: entradaDescricao);

            repositorioSerie.Atualiza(indiceSerie, atualizaSerie);
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");

            var lista = repositorioSerie.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }
            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();
                
                Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluido*" : ""));
            }
        }

        private static void ListarFilmes()
        {
            Console.WriteLine("Listar filmes");

            var lista = repositorioFilme.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma filme cadastrado.");
                return;
            }
            foreach (var filme in lista)
            {
                var excluido = filme.retornaExcluido();

                Console.WriteLine("#ID {0}: - {1} {2}", filme.retornaId(), filme.retornaTitulo(), (excluido ? "*Excluido*" : ""));
            }
        }

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorioSerie.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            
            repositorioSerie.Insere(novaSerie);
            
        }

        private static void InserirFilmes()
        {
            Console.WriteLine("Inserir novo filme");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Título do Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Início do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição do Filme: ");
            string entradaDescricao = Console.ReadLine();

            Filme novoFilme = new Filme(id: repositorioSerie.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorioFilme.Insere(novoFilme);

        }
        private static string ObterOpcaoUsuarioSeries()
        {
            Console.WriteLine();
            //Console.WriteLine("DIO Séries a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuarioSeries = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuarioSeries;

        }

        private static string ObterOpcaoUsuarioFilmes()
        {
            Console.WriteLine();
            //Console.WriteLine("DIO Séries a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Listar filme");
            Console.WriteLine("2 - Inserir novo filme");
            Console.WriteLine("3 - Atualizar filme");
            Console.WriteLine("4 - Excluir filme");
            Console.WriteLine("5 - Visualizar filme");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuarioFilmes = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuarioFilmes;

        }

        private static string ObterTipoCadastro()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries e Filmes a seu dispor!!!");
            Console.WriteLine("Informe o tipo de cadastro desejado:");

            
            Console.WriteLine("1 - Séries");
            Console.WriteLine("2 - Filmes");

            string tipoCadastro = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return tipoCadastro;
        }

    }
}