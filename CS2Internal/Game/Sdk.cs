using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace CS2Internal.Game;

public class Entity
{
    public EntityPawn EntityPawn;
    public EntityController EntityController;
}

[StructLayout(LayoutKind.Explicit)]
public struct EntityController
{
    [FieldOffset(CCSPlayerController.m_sSanitizedPlayerName)]
    private IntPtr sanitizedPlayerNameBytes;

    public string? SanitizedPlayerName
    {
        get => sanitizedPlayerNameBytes != IntPtr.Zero ? Marshal.PtrToStringAnsi(sanitizedPlayerNameBytes) : null;
        set => sanitizedPlayerNameBytes = value is not null ? Marshal.StringToHGlobalAnsi(value) : IntPtr.Zero;
    }
}

[StructLayout(LayoutKind.Explicit)]
public struct EntityPawn
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

    [FieldOffset(C_CSPlayerPawnBase.m_iIDEntIndex)]
    public int IdEntIndex;

    [FieldOffset(C_CSPlayerPawn.m_aimPunchCache)]
    public CUtlVector AimPunchCache;

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

public struct CUtlVector
{
    public ulong Count;
    public ulong Data;
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
    [FieldOffset(CModelState.m_ModelName)] private IntPtr modelName;

    public string? ModelName
    {
        get => Marshal.PtrToStringAnsi(modelName);
        set => modelName = Marshal.StringToHGlobalAnsi(value);
    }
}