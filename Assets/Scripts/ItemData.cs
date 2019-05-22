using UnityEngine;

public static class ItemData
{
    public static Item CreateItem(int itemID)
    {
        string name = "";
        int value = 0;
        string description = "";
        string icon = "";
        string mesh = "";
        ItemType type = ItemType.Food;
        int heal = 0;
        int damage = 0;
        int armour = 0;
        int amount = 0;

        switch (itemID)
        {
            #region Food 0-99
            case 0:
                 name = "Meat";
                 value = 5;
                 description = "Meat of mysterious origin";
                 icon = "Food/Meat_Icon";
                 mesh = "Food/Meat_Mesh";
                 type = ItemType.Food;
                 heal = 17;
                 amount = 1;
                break;
            case 1:
                name = "Chicken";
                value = 3;
                description = "From birb";
                icon = "Food/Chicken_Icon";
                mesh = "Food/Chicken_Mesh";
                type = ItemType.Food;
                heal = 12;
                amount = 1;
                break;
            case 2:
                name = "Bread";
                value = 2;
                description = "Peasant Food";
                icon = "Food/Bread_Icon";
                mesh = "Food/Bread_Mesh";
                type = ItemType.Food;
                heal = 10;
                amount = 1;
                break;
            #endregion
            #region Weapon 100-199
            case 100:
                name = "Sword";
                value = 100;
                description = "Bladed weapon of tempered steel. Used to slice and stab foes";
                icon = "Sword_Icon";
                mesh = "Sword_Mesh";
                type = ItemType.Weapon;
                damage = 10;
                amount = 1;
                break;
            case 101:
                name = "Shortsword";
                value = 80;
                description = "Short bladed weapon of iron. Used to slice and stab foes";
                icon = "Shortsword_Icon";
                mesh = "Shortsword_Mesh";
                type = ItemType.Weapon;
                damage = 6;
                amount = 1;
                break;
            case 102:
                name = "War Axe";
                value = 120;
                description = "Bladed weapon with a heavy axe head. Powerful, but slow. Used to sunder foes";
                icon = "War_Axe_Icon";
                mesh = "War_Axe_Mesh";
                type = ItemType.Weapon;
                damage = 14;
                amount = 1;
                break;
            case 103:
                name = "Mace";
                value = 125;
                description = "Blunt weapon with an extremely heavy mace head. Hits really hard, but really slow. Used to crush foes";
                icon = "Mace_Icon";
                mesh = "Mace_Mesh";
                type = ItemType.Weapon;
                damage = 16;
                amount = 1;
                break;
            #endregion
            #region Apparel 200-299
            case 200:
                name = "Peasant's Hood";
                value = 3;
                description = "Hood.";
                icon = "Peasant's_Hood_Icon";
                mesh = "Peasant's_Hood_Mesh";
                type = ItemType.Apparel;
                armour = 3;
                amount = 1;
                break;
            case 201:
                name = "Thief's Hood";
                value = 10;
                description = "Cooler hood.";
                icon = "Thief's_Hood_Icon";
                mesh = "Thief's_Hood_Mesh";
                type = ItemType.Apparel;
                armour = 8;
                amount = 1;
                break;
            case 202:
                name = "Wizard's Hood";
                value = 15;
                description = "Chad hood.";
                icon = "Wizard's_Hood_Icon";
                mesh = "Wizard's_Hood_Mesh";
                type = ItemType.Apparel;
                armour = 5;
                amount = 1;
                break;
            #endregion
            #region Crafting 300-399
            case 300:
                name = "Steel Ingot";
                value = 10;
                description = "A bar of steel. Crafting material";
                icon = "Steel_Ingot_Icon";
                mesh = "Steel_Ingot_Mesh";
                type = ItemType.Crafting;
                amount = 1;
                break;
            case 301:
                name = "Oak Lumber";
                value = 10;
                description = "Lumber made form an oak tree. Crafting material";
                icon = "Oak_Lumber_Icon";
                mesh = "Oak_Lumber_Mesh";
                type = ItemType.Crafting;
                amount = 1;
                break;
            case 302:
                name = "Gold Ingot";
                value = 250;
                description = "A bar of gold. Highly valuable. Crafting material";
                icon = "Gold_Ingot_Icon";
                mesh = "Gold_Ingot_Mesh";
                type = ItemType.Crafting;
                amount = 1;
                break;
            #endregion
            #region Quest 400-499
            #endregion
            #region Ingredients 500-599
            #endregion
            #region Potions 600-699
            #endregion
            #region Scrolls 700-799
            #endregion
            default:
                itemID = 4;
                name = "Apple";
                value = 5;
                description = "Crisp fruit. Healthy snack. Found in apple trees";
                icon = "Food/Apple_Icon";
                mesh = "Food/Apple_Mesh";
                type = ItemType.Food;
                heal = 5;
                amount = 1;
            break;
        }
        Item temp = new Item
        {
            Name = name,
            Description = description,
            ID = itemID,
            Value = value,
            Damage = damage,
            Armour = armour,
            Amount = amount,
            Heal = heal,
            Type = type,
            Mesh = Resources.Load("Prefabs/"+ mesh) as GameObject,
            Icon = Resources.Load("Icons/" + icon) as Texture2D,
        };
        return temp;
    }
}
