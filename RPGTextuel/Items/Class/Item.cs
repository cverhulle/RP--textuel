using RPGTextuel.Core.Characters;

namespace RPGTextuel.Items.Class
{
    // On crée une classe abstraite appelée Item
    public abstract class Item
    {
        // On liste ses attributs
        public string name { get; protected set; }

        // On implémente son constructeur.
        public Item(string nameItem)
        {
            name = nameItem;
        }

        // On oblige les classes dérivées à définir une méthode Use.
        public abstract void Use(Character target);
    }
}