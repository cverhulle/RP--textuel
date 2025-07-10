using RPGTextuel.Core;
using RPGTextuel.Enemies.Class;
using RPGTextuel.Extensions.Characters;
using RPGTextuel.Game.GameUtilsNamespace;

namespace RPGTextuel.Game.GameFeatures.Fight
{
    // Cette classe s'occupe de l'affichage dans les combats.
    public static class BattleDisplay
    {
        // Cette classe s'occupe d'afficher les infos sur les deux adversaires en combat.
        public static void ShowBattleState(Player player, Enemy enemy)
        {
            Console.Clear();
            Console.WriteLine("===== COMBAT EN COURS =====");

            // Affichage de la santé du joueur
            player.PrintHealthBar();

            // Affichage de la santé de l'ennemi.
            enemy.PrintHealthBar();

            Console.WriteLine("============================");
        }

        // Cette méthode gère l'affichage du résultat du combat.
        public static void ShowBattleResult(Player player, Enemy enemy)
        {
            Console.Clear();

            Console.WriteLine("===== FIN DU COMBAT =====\n");

            // On affiche un message relatif au résultat du combat.
            if (player.IsAlive && !enemy.IsAlive)
            {
                Console.WriteLine($"🎉 Victoire ! {enemy.Name} a été vaincu. \n");
                player.PrintHealthBar();
            }
            else if (!player.IsAlive && enemy.IsAlive)
            {
                Console.WriteLine($"💀 Défaite... {player.Name} a été terrassé par {enemy.Name}.");
            }
            else
            {
                Console.WriteLine("Erreur : Fin prématurée du combat.");
            }
            
            // On attend l'appui de l'utilisateur pour continuer.
            GameUtils.WaitForUser("Appuyez sur une touche pour continuer...");
        }
    }
}