using RecipeProject.Domain.Model;
using System.Collections.Generic;

namespace RecipeProject.Infra.Data
{
    public class SeedData
    {
        public static List<Recipe> Seed()
        {
            List<Recipe> recipes = new List<Recipe>();
            recipes.Add(new Recipe()
            {

                RecipeId = 1,

                Name = "Bacalhau com natas",

                User = new User()
                {
                    Id = 1,
                    Name = "Ingrid",
                },

                Category = new Category()
                {
                    CategoryId = 1,
                    Name = "Portugal",
                },

                Dificulty = new Dificulty(Domain.Model.Enums.DificultyOption.Fácil),

                //Ingredients = new List<RecipeIngredients>()

                PreparationMethod = "Pré-aqueça o forno a 200º C. Corte as batatas em cubos e frite-as em azeite." +
                "Coloque o bacalhau num tacho com uma folha de louro e cubra-o com água. Leve-o a cozinhar em lume alto, " +
                "quando levantar fervura baixe o lume e cozinhe 5 minutos. " +
                "Retire o bacalhau da água e deixe arrefecer. Retire a pele e as espinhas e desfie-o em lascas." +
                "Num tacho, coloque 100 ml de azeite e deixe refogar as cebolas, os alhos e uma folha de louro. " +
                "Adicione o bacalhau, mexa e deixe refogar um pouco." +
                "Junte as batatas e envolva bem. Depois, acrescente o molho bechamel e as natas e tempere com o sal," +
                " a pimenta, a noz-moscada e as gotas do limão. Mexa bem, retire do lume e reserve." +
                "Pincele um tabuleiro de forno com o restante azeite. Espalhe bem o preparado de bacalhau no tabuleiro e polvilhe " +
                "com o queijo mozzarella ralado. Leve o bacalhau com natas ao forno a gratinar entre 15 e 20 minutos."


            });

            recipes.Add(new Recipe()
            {

                RecipeId = 2,

                Name = "Feijoada à Brasileira",

                User = new User()
                {
                    Id = 2,
                    Name = "Jaqueline",
                },

                Category = new Category()
                {
                    CategoryId = 2,
                    Name = "Brasil",
                },

                Dificulty = new Dificulty(Domain.Model.Enums.DificultyOption.Difícil),

                //Ingredients = new List<RecipeIngredients>()

                PreparationMethod = "Tempere a jardineira e o entrecosto com sal grosso, tape e guarde no frio de um dia para o outro." +
                "No dia seguinte passe as carnes por água fria e deite-as para um tacho. Junte água fria até ficar coberta e leve ao lume." +
                "Quando ferver junte os chouriços e deixe cozinhar durante 15 minutos." +
                "Retire o chouriço e deixe as carnes cozinhar ate ficarem tenras, retire primeiro entremeada porque coze mais rápido." +
                "Guarde a água de cozer as carnes. Corte as carnes em pedaços pequenos e o chouriço em rodelas grossas." +
                "Descasque a cebola e os alhos, pique tudo e deite para um tacho grande." +
                "Junte o azeite e leve ao lume, deixe aquecer junte o bacon cortado em tiras finas e deixe cozinhar até ficar douradinho." +
                "Junte as carnes cortadas, o louro, o feijão previamente passado por água fria e escorrido e o sumo de laranja." +
                "Misture. Junte água de cozer as carnes até cobrir o feijão, misture e deixe cozinhar até ficar com um molho grosso." +
                "Verifique o sal junte um pouco de pimenta. Misture e deixe cozinhar mais um pouco mexendo de vez em quando." +
                "Sirva quente, acompanhe com mandioca frita, couve de caldo verde salteada, farofa, laranja cortada em meias luas, " +
                "arroz seco e salada.",
                                                

            });

            recipes.Add(new Recipe()
            {

                RecipeId = 3,

                Name = "Frango Xadrez",

                User = new User()
                {
                    Id = 3,
                    Name = "Camila",
                },

                Category = new Category()
                {
                    CategoryId = 3 ,
                    Name = "China",
                },

                Dificulty = new Dificulty(Domain.Model.Enums.DificultyOption.Fácil),

                //Ingredients = new List<RecipeIngredients>()

                PreparationMethod = "Em uma panela (grande) aqueça o óleo em fogo alto e adicione o frango temperado com sal e cebolinha. " +
                "Refogue por 5 minutos. Abaixe o fogo, acrescente a cebola, o pimentão, o brócolis, o repolho, a cenoura e deixa cozinhar " +
                "por 10 minutos. Junte o molho de soja, o amido de milho dissolvido na água e misture bem até que forme um molho espesso." +
                "Desligue o fogo e, se desejar, sirva acompanhado de arroz."


            });

            recipes.Add(new Recipe()
            {

                RecipeId = 4,

                Name = "Turquia",

                User = new User()
                {
                    Id = 3,
                    Name = "Sérgio",
                },

                Category = new Category()
                {
                    CategoryId = 4,
                    Name = "Turquia",
                },

                Dificulty = new Dificulty(Domain.Model.Enums.DificultyOption.Difícil),

                //Ingredients = new List<RecipeIngredients>()

                PreparationMethod = "Massa Filo: Faça uma massa com farinha de trigo; Em seguida junte o sal e algumas " +
                "colheres de sopa de água até que fique elástica; Cubra com um pano e deixe descansar por cerca de 1 hora;" +
                "Depois disso, achate bem e molde quatro pedaços em formato oval, com cerca de 10 cm de comprimento e 5 cm de largura;" +
                "Coloque azeite em uma panela e leve ao fogo baixo; Recheio: Coloque azeite em uma panela e leve ao fogo baixo;" +
                "Em seguida, adicione alho e misture com o azeite utilizando um garfo; Junte os espinafres à panela e deixe cozinhar;" +
                "Sobre uma mesa ou bancada, separe uma forma e estenda os pedaços ovais de massa filo com as medidas do recipiente;" +
                "Quando estiverem cozidos, retire os espinafres da panela e escorra a água; Pincele o fundo da forma reservada com azeite;" +
                "Coloque duas camadas de massa sobre a forma e entre cada uma delas, adicione um pouco de azeite;" +
                "Esfarele as nozes e misture aos espinafres e ao Queijo Feta em uma tigela; Em seguida, coloque a mistura sobre duas " +
                "camadas de massa na forma; Cubra o recheio com as outras duas camadas de massa, adicionando azeite entre cada uma delas;" +
                "Pincele com um pouco mais de azeite por cima da última camada e leve ao forno com temperatura de 200°C por cerca de 20 minutos " +
                "até que a fique dourado"

            });

            recipes.Add(new Recipe()
            {

                RecipeId = 5,

                Name = "Shimeji",

                User = new User()
                {
                    Id = 5 ,
                    Name = "Ricardo",
                },

                Category = new Category()
                {
                    CategoryId = 5,
                    Name = "Japão",
                },

                Dificulty = new Dificulty(Domain.Model.Enums.DificultyOption.Difícil),

                //Ingredients = new List<RecipeIngredients>()

                PreparationMethod = "Comece o preparo picando bem o cogumelo, tirando o talo que vem junto com eles. " +
                "Caso estejam sujos, use um pano úmido para limpa-los evitando jogar água (pois eles podem inchar)" +
                "Use uma frigideira para derreter a manteiga e coloque os cogumelos para dourar. " +
                "Acrescente o shoyu e mexa bem, até que tudo incorpore e que o shimeji cozinhe por mais 5 minutos (reduzindo o fogo)." +
                "Sirva com um pouco de cebolinha por cima, ainda quente!"


            });

            recipes.Add(new Recipe()
            {

                RecipeId = 6,

                Name = "Espanha",

                User = new User()
                {
                    Id = 6,
                    Name = "João",
                },

                Category = new Category()
                {
                    CategoryId = 6,
                    Name = "Espanha",
                },

                Dificulty = new Dificulty(Domain.Model.Enums.DificultyOption.Difícil),

                //Ingredients = new List<RecipeIngredients>()

                PreparationMethod = "Descasque as batatas e corte-as em meias-rodelas bem finas. Corte a cebola também em meias-rodelas " +
                "porém, um pouco mais grossas. Esquente o óleo em uma frigideira e frite as batatas e a cebola em fogo médio, quando as " +
                "batatas estiverem macias. Retire tudo da frigideira com a ajuda de uma escumadeira.Bata os ovos em uma tigela até que " +
                "fiquem espumantes. Acrecente as batatas e cebola aos ovos e tempere com cebolinha, sal e pimenta. Misture bem" +
                "Esquente uma frigideira (de preferência antiaderente) com um pouquinho de óleo e jogue a mistura. Cozinhe em fogo " +
                "baixo até que a parte inferior fique dourada. Depois disso, vire a massa e doure do outro lado. Pode ser servida quente " +
                "ou fria."


            });

            return recipes;
        }


    }
}
