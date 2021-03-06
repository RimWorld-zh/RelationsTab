﻿// Karel Kroeze
// Resources.cs
// 2016-12-26

using System.Reflection;
using RimWorld;
using UnityEngine;
using Verse;

namespace Fluffy_Relations
{
    [StaticConstructorOnStartup]
    public static class Resources
    {
        #region Fields

        public static Rect baseSlot = new Rect(0f, 0f, Constants.SlotSize, Constants.SlotSize);

        // colors
        public static Color
            ColorNeutral = Color.grey,
            ColorFriend = Color.green,
            ColorEnemy = Color.red,
            ColorLover = GenUI.MouseoverColor,
            ColorExLover = Color.cyan,
            ColorFamily = Color.white;

        public static MethodInfo DrawSocialLogMI = typeof(SocialCardUtility).GetMethod("DrawInteractionsLog",
                                                                                          BindingFlags.Static |
                                                                                          BindingFlags.NonPublic);

        public static Texture2D
            SlightlyDarkBG = SolidColorMaterials.NewSolidColorTexture(new Color(0f, 0f, 0f, .4f)),
            Solid = SolidColorMaterials.NewSolidColorTexture(Color.white),

            //// icons
            DotsCircle = ContentFinder<Texture2D>.Get("UI/Icons/DotsCircle"),
            DotsDynamic = ContentFinder<Texture2D>.Get("UI/Icons/DotsDynamic"),
            Cog = ContentFinder<Texture2D>.Get("UI/Icons/Cog"),
            Pin = ContentFinder<Texture2D>.Get("UI/Icons/Pin"),

            // misc
            Halo = ContentFinder<Texture2D>.Get("UI/Misc/Halo");

        #endregion Fields
    }
}
