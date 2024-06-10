using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "World", menuName = "Level")]
public class Level : ScriptableObject
{
    [Header("Размеры игровой доски")]
    public int width;
    public int height;

    [Header("Начальные плитки")]
    public TileType[] boardLayout;

    [Header("Доступные точки")]
    public GameObject[] dots;

    [Header("Цели")]
    public int[] scoreGoals;

    [Header("Требования для прохождения уровня")]
    public EndGameRequirements endGameRequirements;
    public BlankGoal[] levelGoals;

}
