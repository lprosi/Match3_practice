using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "World", menuName = "Level")]
public class Level : ScriptableObject
{
    [Header("������� ������� �����")]
    public int width;
    public int height;

    [Header("��������� ������")]
    public TileType[] boardLayout;

    [Header("��������� �����")]
    public GameObject[] dots;

    [Header("����")]
    public int[] scoreGoals;

    [Header("���������� ��� ����������� ������")]
    public EndGameRequirements endGameRequirements;
    public BlankGoal[] levelGoals;

}
