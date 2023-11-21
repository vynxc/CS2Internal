using System.Numerics;
using System.Runtime.InteropServices;

namespace CS2Internal.Game;

[StructLayout(LayoutKind.Explicit)]
public struct Entity
{
    [FieldOffset(C_BaseEntity.m_iHealth)] public int Health;

    [FieldOffset(C_BaseEntity.m_pGameSceneNode)]
    public unsafe GameSceneNode* SceneNode;

    [FieldOffset(C_BaseEntity.m_iTeamNum)] public int TeamNum;

    [FieldOffset(C_CSPlayerPawnBase.m_entitySpottedState)]
    public EntitySpottedState EntitySpottedState;
}

[StructLayout(LayoutKind.Explicit)]
public unsafe struct EntitySpottedState
{
    [FieldOffset(EntitySpottedState_t.m_bSpotted)]
    public bool Spotted;

    [FieldOffset(EntitySpottedState_t.m_bSpottedByMask)]
    public fixed uint SpottedByMask[2];
}

[StructLayout(LayoutKind.Explicit)]
public struct GameSceneNode
{
    [FieldOffset(CGameSceneNode.m_vecAbsOrigin)]
    public Vector3 VecOriginAbsolute;

    [FieldOffset(CGameSceneNode.m_bDormant)]
    public bool Dormant;

    [FieldOffset(CSkeletonInstance.m_modelState)]
    public ModelState ModalState;
}

[StructLayout(LayoutKind.Explicit)]
public struct ModelState
{
    [FieldOffset(0x80)] public IntPtr BoneArray;
}