﻿using System.Numerics;
using System.Runtime.InteropServices;

namespace CS2Internal.Game;

[StructLayout(LayoutKind.Explicit)]
public struct Entity
{
    [FieldOffset(C_BaseEntity.m_iHealth)] public int Health;

    [FieldOffset(C_BaseEntity.m_pGameSceneNode)]
    public unsafe GameSceneNode* SceneNode;

    [FieldOffset(C_BaseEntity.m_iTeamNum)] public int TeamNum;

    [FieldOffset(C_BaseModelEntity.m_vecViewOffset)]
    public Vector3 ViewOffset;

    [FieldOffset(C_CSPlayerPawnBase.m_entitySpottedState)]
    public EntitySpottedState EntitySpottedState;

    [FieldOffset(C_CSPlayerPawnBase.m_iShotsFired)]
    public int ShotsFired;

    [FieldOffset(C_CSPlayerPawn.m_aimPunchAngle)]
    public Vector3 AimPunchAngle;

    [FieldOffset(C_CSPlayerPawnBase.m_vecLastClipCameraPos)]
    public Vector3 CameraPosition;

    [FieldOffset(C_CSPlayerPawnBase.m_angEyeAngles)]
    public Vector3 ViewAngle;
}

[StructLayout(LayoutKind.Explicit)]
public struct EntitySpottedState
{
    [FieldOffset(EntitySpottedState_t.m_bSpotted)]
    public bool Spotted;
}

[StructLayout(LayoutKind.Explicit)]
public struct GameSceneNode
{
    [FieldOffset(CGameSceneNode.m_vecAbsOrigin)]
    public Vector3 VecOriginAbsolute;


    [FieldOffset(CGameSceneNode.m_bDormant)]
    public int Dormant;

    [FieldOffset(CSkeletonInstance.m_modelState)]
    public ModelState ModalState;

    [FieldOffset(CGameSceneNode.m_angRotation)]
    public Vector3 ViewAngle;
}

[StructLayout(LayoutKind.Explicit)]
public struct ModelState
{
    [FieldOffset(0x80)] public IntPtr BoneArray;
}