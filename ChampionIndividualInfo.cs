using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ChampionData
{
    public string type;
    public string format;
    public string version;
    public ChampionInfo data;
}

[System.Serializable]
public class ChampionInfo
{
    public ChampionDetails
    Aatrox, Ahri, Akali, Akshan, Alistar, Amumu, Anivia, Annie, Aphelios, Ashe,
    AurelionSol, Azir, Bard, Belveth, Blitzcrank, Brand, Braum, Briar, Caitlyn, Camille,
    Cassiopeia, Chogath, Corki, Darius, Diana, Draven, DrMundo, Ekko, Elise, Evelynn,
    Ezreal, Fiddlesticks, Fiora, Fizz, Galio, Gangplank, Garen, Gnar, Gragas, Graves,
    Gwen, Hecarim, Heimerdinger, Illaoi, Irelia, Ivern, Janna, JarvanIV, Jax, Jayce,
    Jhin, Jinx, Kaisa, Kalista, Karma, Karthus, Kassadin, Katarina, Kayle, Kayn,
    Kennen, Khazix, Kindred, Kled, KogMaw, KSante, Leblanc, LeeSin, Leona, Lillia,
    Lissandra, Lucian, Lulu, Lux, Malphite, Malzahar, Maokai, MasterYi, Milio, MissFortune,
    MonkeyKing, Mordekaiser, Morgana, Naafiri, Nami, Nasus, Nautilus, Neeko, Nidalee, Nilah,
    Nocturne, Nunu, Olaf, Orianna, Ornn, Pantheon, Poppy, Pyke, Qiyana, Quinn,
    Rakan, Rammus, RekSai, Rell, Renata, Renekton, Rengar, Riven, Rumble, Ryze,
    Samira, Sejuani, Senna, Seraphine, Sett, Shaco, Shen, Shyvana, Singed, Sion,
    Sivir, Skarner, Sona, Soraka, Swain, Sylas, Syndra, TahmKench, Taliyah, Talon,
    Taric, Teemo, Thresh, Tristana, Trundle, Tryndamere, TwistedFate, Twitch, Udyr, Urgot,
    Varus, Vayne, Veigar, Velkoz, Vex, Vi, Viego, Viktor, Vladimir, Volibear,
    Warwick, Xayah, Xerath, XinZhao, Yasuo, Yone, Yorick, Yuumi, Zac, Zed,
    Zeri, Ziggs, Zilean, Zoe, Zyra;
}

[System.Serializable]
public class ChampionDetails
{
    public string id;
    public string name;
    public List<string> allytips;
    public List<string> enemytips;
    public List<string> tags;
    public string partype;
    public ChampionInfoDetails info;
    public ChampionStats stats;
    public List<ChampionSpell> spells;
    public ChampionPassive passive;
    public List<string> recommended;
}

[System.Serializable]
public class ChampionInfoDetails
{
    public int attack;
    public int defense;
    public int magic;
    public int difficulty;
}

[System.Serializable]
public class ChampionStats
{
    public int hp;
    public int hpperlevel;
    public int mp;
    public int mpperlevel;
    public int movespeed;
    public int armor;
    public float armorperlevel;
    public int spellblock;
    public float spellblockperlevel;
    public int attackrange;
    public int hpregen;
    public float hpregenperlevel;
    public int mpregen;
    public float mpregenperlevel;
    public int crit;
    public int critperlevel;
    public int attackdamage;
    public float attackdamageperlevel;
    public float attackspeedperlevel;
    public float attackspeed;
}

[System.Serializable]
public class ChampionSpell
{
    public string id;
    public string name;
    public string description;
    public string tooltip;
    public ChampionSpellLevelTip leveltip;
    public int maxrank;
    public List<float> cooldown;
    public string cooldownBurn;
    public List<int> cost;
    public string costBurn;
    public List<object> datavalues;
    public List<object> effect;
    public List<object> effectBurn;
    public List<object> vars;
    public string costType;
    public string maxammo;
    public List<int> range;
    public string rangeBurn;
    public string resource;
}

[System.Serializable]
public class ChampionSpellLevelTip
{
    public List<string> label;
    public List<string> effect;
}

[System.Serializable]
public class ChampionPassive
{
    public string name;
    public string description;
}