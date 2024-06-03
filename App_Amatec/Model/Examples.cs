using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Amatec.Model
{

    public class Examples
    {

        public static List<Content> animes = new List<Content>()
        {
        
            new Content()
            {

                nome = "Demon Slayer (Temporada 04)",

                sinopse = "Japão, era Taisho. Tanjiro, um bondoso jovem que ganha a vida vendendo carvão, " +
                          "descobre que sua família foi massacrada por um demônio, e, para piorar, Nezuko, sua " +
                          "irmã mais nova, e única sobrevivente, também foi transformada em um demônio. Arrasado com " +
                          "esta sombria realidade, ele decide se tornar um matador de demônios, para fazer sua " +
                          "irmã voltar a ser humana, e para matar o demônio que matou sua família. Um triste conto " +
                          "sobre dois irmãos, onde os destinos dos humanos e dos demônios se entrelaçam, começa agora.",

                poster = "App_Amatec.Assets.Images.Animes.01.jpg",

                data_lancamento = new DateTime(2024, 05, 12),

                forma_consumo = "Crunchyroll",

                link_trailer = "https://www.youtube.com/embed/k9ex2xuoQZs?si=GvXTpcF6BukiQ2n6"

            },

            new Content()
            {

                nome = "Solo Leveling (Temporada 01)",

                sinopse = "Conhecido como o caçador mais fraco de toda a humanidade, a contribuição do caçador de " +
                          "rank E, Sung Jin Woo, nas invasões de masmorras, se resume ao equivalente a tentar não ser morto. " +
                          "Infelizmente, entre as contas do hospital de sua mãe, as mensalidades escolares de sua irmã e sua " +
                          "própria falta de perspectivas de emprego, ele não tem escolha a não ser continuar colocando sua vida em risco. " +
                          "Então, quando surge uma oportunidade para um pagamento maior, ele aceita… apenas para ficar " +
                          "cara a cara com um ser cujo poder supera tudo o que ele já viu! Com o líder do grupo sem um " +
                          "braço, e a única curandeira em estado de choque, ele conseguirá encontrar uma saída de alguma forma?",

                poster = "App_Amatec.Assets.Images.Animes.02.jpg",

                data_lancamento = new DateTime(2024, 01, 06),

                forma_consumo = "Crunchyroll",

                link_trailer = "https://www.youtube.com/embed/1ZrcPyhO54c?si=Qbl1FHl1dAUlX5jl"

            },

            new Content()
            {

                nome = "Kaiju Nº 8 (Temporada 01)",

                sinopse = "Monstros grotescos, semelhantes ao Godzilla e conhecidos pelo termo “Kaiju”, têm surgido pelo " +
                          "Japão durante vários anos. Para lutar contra essas feras, uma unidade militar de elite, " +
                          "denominada Corpo de Defesa, arrisca as vidas de seus membros todos os dias para proteger a população civil. " +
                          "Após a morte de uma criatura, os “varredores”, empregados pela Corporação Profissional de " +
                          "Limpeza de Kaiju, são responsáveis por eliminar seus restos mortais. Kafka Hibino, um homem de " +
                          "32 anos, não está satisfeito com seu trabalho como varredor. Desde jovem, ele sonha em se " +
                          "juntar ao Corpo de Defesa e viver para matar kaijus, no entanto, após algumas tentativas " +
                          "frustradas, ele desiste de seus sonhos e se conforma com uma vida de mediocridade, que ao menos, " +
                          "lhe garante um bom salário. Contudo, a chegada de um jovem recruta ambicioso, de 18 anos, chamado " +
                          "Leno Ichikawa, em sua equipe de limpeza, o faz reacender seu desejo de entrar para o exército do Corpo de Defesa. " +
                          "Após uma série de eventos infelizes, e um encontro com o varredor mais novo, Kafka tem um encontro " +
                          "com um kaiju parasita, que entra em seu corpo, através de sua boca, transformando-o em um monstro humanoide. " +
                          "Com seus novos poderes, Kafka decide dar mais uma chance ao seu sonho de vida.",

                poster = "App_Amatec.Assets.Images.Animes.03.jpg",

                data_lancamento = new DateTime(2024, 04, 13),

                forma_consumo = "Crunchyroll",

                link_trailer = "https://www.youtube.com/embed/qGvHTuFeulM?si=p2figzdQINK6cZex"

            },

            new Content()
            {

                nome = "Ninja Kamui (Temporada 01)",

                sinopse = "Joe Higan, um Nukenin (Ninja renegado.), escapou de seu antigo clã e se esconde " +
                          "do seu passado violento, na zona rural da América, com a sua família (Esposa e filho.). " +
                          "Uma noite, ele é emboscado por uma equipe de assassinos, que pertencem a sua antiga " +
                          "organização, que impõem uma retribuição sangrenta a ele, matando sua família, devido " +
                          "a ele ter traído o seu antigo código.",

                poster = "App_Amatec.Assets.Images.Animes.04.jpg",

                data_lancamento = new DateTime(2024, 02, 11),

                forma_consumo = "HBO Max",

                link_trailer = "https://www.youtube.com/embed/90whRiEwxnU?si=N8au7rAFxRAgoDVc"

            }

        };

        public static List<Content> movies = new List<Content>()
        {

            new Content()
            {

                nome = "Deadpool & Wolverine",

                sinopse = "Wolverine está se recuperando, quando cruza seu caminho com o de Deadpool. " +
                          "Juntos, eles formam uma equipe e enfrentam um inimigo em comum.",

                poster = "App_Amatec.Assets.Images.Movies.01.jpg",

                data_lancamento = new DateTime(2024, 07, 26),

                forma_consumo = "Cinemas",

                link_trailer = "https://www.youtube.com/embed/dEbe0rS4Z2A?si=sY2jDr8Z2vr5up5G"

            },

            new Content()
            {

                nome = "Uma ideia de você",

                sinopse = "Solène, uma mãe solteira de 40 anos, embarca em um romance inesperado com Hayes " +
                          "Campbell, o vocalista de 24 anos da August Moon, a banda de garotos mais popular do planeta.",

                poster = "App_Amatec.Assets.Images.Movies.02.jpg",

                data_lancamento = new DateTime(2024, 05, 02),

                forma_consumo = "Amazon\nPrime Vídeo",

                link_trailer = "https://www.youtube.com/embed/ZeIGZdfmBhg?si=wGgkBLYvF6DCl-8i"

            },

            new Content()
            {

                nome = "Mufasa: o rei leão",

                sinopse = "Mufasa, um filhote órfão, perdido e sozinho, conhece um simpático leão, chamado " +
                          "Taka, herdeiro de uma linhagem real. O encontro ao acaso, dá início a uma grande " +
                          "jornada de um grupo extraordinário de deslocados em busca de seu destino, além de " +
                          "revelar a ascensão de um dos maiores reis das Terras do Orgulho.",

                poster = "App_Amatec.Assets.Images.Movies.03.jpg",

                data_lancamento = new DateTime(2024, 12, 19),

                forma_consumo = "Cinemas",

                link_trailer = "https://www.youtube.com/embed/ZSD6LVpRi-k?si=YwBxkDlbedBMPgrc"

            },

            new Content()
            {

                nome = "Venom: a última rodada",

                sinopse = "Eddie e Venom estão em fuga. Caçados por figuras de ambos os seus mundos, " +
                          "e com os caminhos se fechando, a dupla é forçada a unir forças em sua aventura final.",

                poster = "App_Amatec.Assets.Images.Movies.04.jpg",

                data_lancamento = new DateTime(2024, 10, 24),

                forma_consumo = "Cinemas",

                link_trailer = "https://www.youtube.com/embed/c-1i96qpF-s?si=i4o7dexr8Dclnij4"

            }

        };

        public static List<Content> series = new List<Content>()
        {

            new Content()
            {

                nome = "Bridgerton (Temporada 03)",

                sinopse = "Penelope sairá em busca de um marido, de preferência um que lhe ofereça " +
                          "independência o suficiente para que ela siga sua vida dupla como a grande Lady " +
                          "Whistledown. Enquanto isso, Colin retorna de suas viagens de verão.",

                poster = "App_Amatec.Assets.Images.Series.01.jpg",

                data_lancamento = new DateTime(2024, 05, 16),

                forma_consumo = "Netflix",

                link_trailer = "https://www.youtube.com/embed/sA6xIbcaZsw?si=VjcmX_tYyIzqtSy4"

            },

            new Content()
            {

                nome = "Bebê Rena (Minissérie)",

                sinopse = "Ainda em 2015, quando trabalhava em um café, na cidade de Londres, Donny " +
                          "(Richard Gadd.), ofereceu um chá e conversou com uma mulher que, até então, não sabia " +
                          "quem era. Nos três anos seguintes, ela começou a se demonstrar uma perseguidora, " +
                          "completamente obcecada por ele.",

                poster = "App_Amatec.Assets.Images.Series.02.jpg",

                data_lancamento = new DateTime(2024, 04, 11),

                forma_consumo = "Netflix",

                link_trailer = "https://www.youtube.com/embed/RXxkJiLqCLE?si=IdqF721r49GmJD9p"

            },

            new Content()
            {

                nome = "Fallout (Temporada 01)",

                sinopse = "Baseada em uma das maiores séries de videogame de todos os tempos, Fallout " +
                          "é a história de quem tem e de quem não tem, em um mundo onde não existe quase " +
                          "nada para se ter. 200 anos após o apocalipse, uma habitante pacífica, de um " +
                          "agradável refúgio, é forçada a se aventurar na superfície, e fica chocada quando " +
                          "descobre a terra devastada que a espera.",

                poster = "App_Amatec.Assets.Images.Series.03.jpg",

                data_lancamento = new DateTime(2024, 04, 11),

                forma_consumo = "Amazon\nPrime Vídeo",

                link_trailer = "https://www.youtube.com/embed/zGyKzPsmxF8?si=d6g2GTEw4EXd7Vx0"

            },

            new Content()
            {

                nome = "Avatar (Temporada 01)",

                sinopse = "As quatro nações viviam em harmonia com o Avatar, mestre de todos os quatro elementos, " +
                          "mantendo a paz entre todos, mas tudo mudou, quando a Nação do Fogo atacou e exterminou os " +
                          "Nômades do Ar, para os dobradores de fogo conquistarem o mundo. Com o desaparecimento do " +
                          "Avatar, o mundo perdeu a esperança.",

                poster = "App_Amatec.Assets.Images.Series.04.jpg",

                data_lancamento = new DateTime(2024, 02, 22),

                forma_consumo = "Netflix",

                link_trailer = "https://www.youtube.com/embed/5llvd1Uu-iU?si=nHIVsx-YYpeepP3W"

            }

        };

    }

}
