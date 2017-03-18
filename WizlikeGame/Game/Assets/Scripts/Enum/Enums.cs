using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum Attribute
{
	//属性の設定
	Fire,
	Water,
	Ice,
	Ground,
	Shine,
	Dark,
	None,
}

public static class AttributeExtension
{
	public static Attribute ToEnum(string val)
	{
		return (Attribute)Enum.Parse(typeof(Attribute), val, true);
	}

	public static String ToString(Attribute attribute)
	{
		switch (attribute)
		{
			case Attribute.Fire: return "火";
			case Attribute.Water: return "水";
			case Attribute.Ice: return "氷";
			case Attribute.Ground: return "土";
			case Attribute.Shine: return "光";
			case Attribute.Dark: return "闇";
			case Attribute.None: return "無";
			default: return "";
		}
	}
}

public enum Tribe
{
	//種族の設定
	Animal,
	LivingDead,
	Spirit,
	Inorganic,
}


public static class TribeExtension
{
	public static Tribe ToEnum(string val)
	{
		return (Tribe)Enum.Parse(typeof(Tribe), val, true);
	}

	public static String ToString(Tribe attribute)
	{
		switch (attribute)
		{
			case Tribe.Animal: return "生物";
			case Tribe.LivingDead: return "不死";
			case Tribe.Spirit: return "精霊";
			case Tribe.Inorganic: return "無機物";
			default: return "";
		}
	}
}

public enum Job
{
	//職業の設定
	Fighter,
	Paladin,
	Samurai,
	Wizard,
	Healer,
	Ranger,
	Assassin,
}


public static class JobExtension
{
	public static Job ToEnum(string val)
	{
		return (Job)Enum.Parse(typeof(Job), val, true);
	}

	public static String ToString(Job attribute)
	{
		switch (attribute)
		{
			case Job.Fighter: return "ファイター";
			case Job.Paladin: return "パラディン";
			case Job.Samurai: return "サムライ";
			case Job.Wizard: return "ウィザード";
			case Job.Healer: return "ヒーラー";
			case Job.Ranger: return "レンジャー";
			case Job.Assassin: return "アサシン";
			default: return "";
		}
	}
}

public enum WeaponType
{
	//装備品のタイプ
	Sword,
	Blade,
	Knife,
	Axe,
	Spear,
	Hummer,
	Gun,
	Bow,
	Cane,
}


public static class WeaponTypeExtension
{
	public static WeaponType ToEnum(string val)
	{
		return (WeaponType)Enum.Parse(typeof(WeaponType), val, true);
	}

	public static String ToString(WeaponType attribute)
	{
		switch (attribute)
		{
			case WeaponType.Sword: return "剣";
			case WeaponType.Blade: return "刀";
			case WeaponType.Knife: return "ナイフ";
			case WeaponType.Axe: return "斧";
			case WeaponType.Spear: return "槍";
			case WeaponType.Hummer: return "ハンマー";
			case WeaponType.Gun: return "銃";
			case WeaponType.Bow: return "弓";
			case WeaponType.Cane: return "杖";
			default: return "";
		}
	}
}

public enum ArmorType
{
	//防具のタイプ
	Shield,
	Helmet,
	Hat,
	LightClothes,
	HeavyClothes,
	Accessory
}


public static class ArmorTypeExtension
{
	public static ArmorType ToEnum(string val)
	{
		return (ArmorType)Enum.Parse(typeof(ArmorType), val, true);
	}

	public static String ToString(ArmorType attribute)
	{
		switch (attribute)
		{
			case ArmorType.Shield: return "盾";
			case ArmorType.Helmet: return "兜";
			case ArmorType.Hat: return "帽子";
			case ArmorType.LightClothes: return "軽装";
			case ArmorType.HeavyClothes: return "重装";
			case ArmorType.Accessory: return "アクセサリー";
			default: return "";
		}
	}
}


public enum ItemType
{
	//アイテムのタイプ
	Recovery,
	Attack,
	Equipment,
	Treasure
}


public static class ItemTypeExtension
{
	public static ItemType ToEnum(string val)
	{
		return (ItemType)Enum.Parse(typeof(ItemType), val, true);
	}

	public static String ToString(ItemType attribute)
	{
		switch (attribute)
		{
			case ItemType.Recovery: return "回復";
			case ItemType.Attack: return "攻撃";
			case ItemType.Equipment: return "装備品";
			case ItemType.Treasure: return "お宝";
			default: return "";
		}
	}
}