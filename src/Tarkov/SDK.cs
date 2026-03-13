namespace SDK
{
	public readonly partial struct Offsets
	{
    	public readonly partial struct AssemblyCSharp
    	{
    	    public const uint TypeStart = 0;
    	    public const uint TypeCount = 16336;
    	}
		//public static class TarkovApplication
		public readonly partial struct TarkovApplication 
		{
			public const uint _menuOperation = 0x128;
		}
		//public static class MainMenuShowOperation
		public readonly partial struct MainMenuShowOperation
		{
			public const uint _afkMonitor = 0x38;
			public const uint _preloaderUI = 0x60;
			public const uint _profile = 0x50;
		}
		//public static class PreloaderUI
		public readonly partial struct PreloaderUI
		{
			public const uint _sessionIdText = 0x118;
			public const uint _alphaVersionLabel = 0x20;
		}
		//public static class AFKMonitor
		public readonly partial struct AfkMonitor
		{
			public const uint Delay = 0x10; //_afkTimeout
		}
		//public static class GameWorld
		public readonly partial struct GameWorld
		{
			public const uint GameDateTime = 0xD8;
			public const uint SynchronizableObjectLogicProcessor = 0x248; //_SynchronizableObjectLogicProcessor_k__BackingField
		}
		//public static class GameWorld
		public readonly partial struct ClientLocalGameWorld
		{
            public const uint BtrController = 0x28; //_BtrController_k__BackingField
            public const uint TransitController = 0x38; //_TransitController_k__BackingField
            public const uint ExfilController = 0x58; //_ExfiltrationController_k__BackingField
            public const uint ClientShellingController = 0xA8; //_ClientShellingController_k__BackingField
            public const uint LocationId = 0xD0; //_LocationId_k__BackingField
            public const uint LootList = 0x198;
            public const uint RegisteredPlayers = 0x1B8;
            public const uint BorderZones = 0x1F0;
            public const uint MainPlayer = 0x210;
            public const uint World = 0x218; //_world
            public const uint SynchronizableObjectLogicProcessor = 0x248; //_SynchronizableObjectLogicProcessor_k__BackingField
            public const uint Grenades = 0x288;
        }
		//public static class TransitController
		public readonly partial struct TransitController
		{
			public const uint TransitPoints = 0x18; //pointsById
		}
		//public static class ArtilleryShellingControllerClient
		public readonly partial struct ClientShellingController
		{
			public const uint ActiveClientProjectiles = 0x68;
		}
		//public static class World_2
		public readonly partial struct WorldController
		{
			public const uint Interactables = 0x30; //_interactables
		}
		//public static class WorldInteractiveObject
		public readonly partial struct Interactable
		{
			public const uint KeyId = 0x60;
			public const uint Id = 0x70;
			public const uint _doorState = 0xD0;
		}
		//public static class ArtilleryProjectileClient
		public readonly partial struct ArtilleryProjectileClient
		{
			public const uint Position = 0x30; //_targetPosition
			public const uint IsActive = 0x3C; //_flyOn
		}
		//public static class TransitPoint
		public readonly partial struct TransitPoint
		{
			public const uint parameters = 0x20;
		}
		//public static class TransitParameters
		public readonly partial struct TransitParameters
		{
			public const uint id = 0x10;
			public const uint active = 0x14;
			public const uint name = 0x18;
			public const uint description = 0x20;
			public const uint target = 0x38;
			public const uint location = 0x40;
		}
		//public static class SynchronizableObject
		public readonly partial struct SynchronizableObject
		{
			public const uint Type = 0x68;
		}
		//public static class SynchronizableObjectLogicProcessor
		public readonly partial struct SynchronizableObjectLogicProcessor
		{
			public const uint _activeSynchronizableObjects = 0x18;
		}
		//public static class TripwireSynchronizableObject
		public readonly partial struct TripwireSynchronizableObject
		{
			public const uint GrenadeTemplateId = 0x118; //_GrenadeTemplateId_k__BackingField
			public const uint _tripwireState = 0xE4;
			public const uint FromPosition = 0x14C; //_FromPosition_k__BackingField
			public const uint ToPosition = 0x158; //_ToPosition_k__BackingField
		}
		//public static class BtrController
		public readonly partial struct BtrController
		{
			public const uint BtrView = 0x50; //_BtrView_k__BackingField
		}
		//public static class BTRView
		public readonly partial struct BTRView
		{
			public const uint turret = 0x60;
			public const uint _targetPosition = 0xAC;
			public const uint _previousPosition = 0xB4; //_previousPosition
		}
		//public static class BTRTurretView
		public readonly partial struct BTRTurretView
		{
			public const uint AttachedBot = 0x60; //_bot
		}
		//public static class EffectsController
		public readonly partial struct EffectsController
		{
			public const uint _effectsPrefab = 0x20;
            public const uint FastVineteFlicker = 0x28;
            public const uint RainScreenDrops = 0x30; //_RainScreenDrops_k__BackingField
            public const uint ScreenWater = 0x38; //_ScreenWater_k__BackingField
            public const uint _vignette = 0x40;
            public const uint _doubleVision = 0x48;
            public const uint _hueFocus = 0x50;
            public const uint _radialBlur = 0x58;
            public const uint _sharpen = 0x60;
            public const uint _lowhHealthBlend = 0x68;
            public const uint _bloodlossBlend = 0x70;
            public const uint _wiggle = 0x78;
            public const uint _motionBluer = 0x80;
            public const uint _bloodOnScreen = 0x88;
            public const uint _grenadeFlash = 0x90;
            public const uint _eyeBurn = 0x98;
            public const uint _blur = 0xA0;
            public const uint _dof = 0xA8;
            public const uint _effectAccumulators = 0xB0;
            public const uint _sharpenAccumulator = 0xB8;
            public const uint _radialBlurAccumulator = 0xC0;
            public const uint _chromaticAberration = 0xC8;
            public const uint _thermalVision = 0xD0;
            public const uint _frostbiteEffect = 0xD8;
		}
		//public static class FrostbiteEffect
		public readonly partial struct FrostbiteEffect
		{
			public const uint _opacity = 0x64;
		}
		//public static class NightVision
		public readonly partial struct NightVision
		{
			public const uint _on = 0xC4;
		}
		//public static class ThermalVision
		public readonly partial struct ThermalVision
		{
			public const uint Material = 0xB8;
			public const uint On = 0x20;
			public const uint IsNoisy = 0x21;
			public const uint IsFpsStuck = 0x22;
			public const uint IsMotionBlurred = 0x23;
			public const uint IsGlitch = 0x24;
			public const uint IsPixelated = 0x25;
			public const uint ChromaticAberrationThermalShift = 0x68;
			public const uint UnsharpRadiusBlur = 0x90;
			public const uint UnsharpBias = 0x94;
		}
		//public static class HealthInfo
		public readonly partial struct HealthController
		{
			public const uint Energy = 0x68;
			public const uint Hydration = 0x70;
		}
		//public static class ExfiltrationController
		public readonly partial struct ExfilController
		{
			public const uint ExfiltrationPointArray = 0x20; //_ExfiltrationPoints_k__BackingField
			public const uint ScavExfiltrationPointArray = 0x28; //_ScavExfiltrationPoints_k__BackingField
			public const uint SecretExfiltrationPointArray = 0x30; //_SecretExfiltrationPoints_k__BackingField
		}
		//public static class ExfiltrationPoint
		public readonly partial struct Exfil
		{
			public const uint _status = 0x58;
			public const uint Settings = 0x98;
			public const uint EligibleEntryPoints = 0xC0;
		}
		//public static class ScavExfiltrationPoint
		public readonly partial struct ScavExfil
		{
			public const uint EligibleIds = 0xF8;
		}
		//public static class ExitTriggerSettings
		public readonly partial struct ExfilSettings
		{
			public const uint Name = 0x18;
		}
		//public static class Grenade + public static class Throwable
		public readonly partial struct Grenade
		{
			public const uint IsDestroyed = 0x4D; //_isDestroyed from Throwable
			public const uint WeaponSource = 0x98; //_WeaponSource_k__BackingField from Grenade
		}
		//public static class Player
		public readonly partial struct Player
		{
			public const uint _characterController = 0x40;
			public const uint MovementContext = 0x60; //_MovementContext_k__BackingField
			public const uint _playerBody = 0x190;
			public const uint ProceduralWeaponAnimation = 0x338; //_ProceduralWeaponAnimation_k__BackingField
			public const uint _animators = 0x640;
			public const uint EnabledAnimators = 0x670;
			public const uint Corpse = 0x680;
			public const uint Location = 0x870; //_Location_k__BackingField
			public const uint InteractableObject = 0x888; //_InteractableObject_k__BackingField
			public const uint Profile = 0x900; //_Profile_k__BackingField
			public const uint Physical = 0x918;
			public const uint AIData = 0x940; //_AIData_k__BackingField
			public const uint _healthController = 0x960;
			public const uint _inventoryController = 0x978;
			public const uint _handsController = 0x980;
			public const uint InteractionRayOriginOnStartOperation = 0xA1C; //_InteractionRayOriginOnStartOperation_k__BackingField
			public const uint InteractionRayDirectionOnStartOperation = 0xA28; //_InteractionRayDirectionOnStartOperation_k__BackingField
			public const uint IsYourPlayer = 0xA89; //_IsYourPlayer_k__BackingField
			public const uint VoipID = 0x8F0; //_VoipID_k__BackingField
			public const uint Id = 0x8F8;  //_PlayerId_k__BackingField
			public const uint GameWorld = 0x5F8; //_GameWorld_k__BackingField
		}
		//public static class ObservedPlayerView
		public readonly partial struct ObservedPlayerView
		{
			public const uint ObservedPlayerController = 0x28; //_ObservedPlayerController_k__BackingField
			public const uint Voice = 0x40; //_Voice_k__BackingField
			public const uint VisibleToCameraType = 0x60; //_VisibleToCameraType_k__BackingField
			public const uint GroupID = 0x80; //_GroupId_k__BackingField
			public const uint Side = 0x94; //_Side_k__BackingField
			public const uint IsAI = 0xA0; //_IsAI_k__BackingField
			public const uint NickName = 0xB8; //_NickName_k__BackingField
			public const uint AccountId = 0xC0; //_AccountId_k__BackingField
			public const uint PlayerBody = 0xD8; //_PlayerBody_k__BackingField
			public const uint Id = 0x7C; //_Id_k__BackingField
			public const uint VoipId = 0xB0; //_VoipID_k__BackingField
		}
		//public static class ObservedPlayerController
		public readonly partial struct ObservedPlayerController
		{
			public const uint InventoryController = 0x10; //_InventoryController_k__BackingField
			public const uint Player = 0x18; //_PlayerView_k__BackingField
			public const uint InfoContainer = 0xD0; //_InfoContainer_k__BackingField
			public static readonly uint[] MovementController = new uint[] { 0xD8, 0x98 }; //_MovementController_k__BackingField
			public const uint HealthController = 0xE8; //_HealthController_k__BackingField
			public const uint HandsController = 0x120; //_HandsController_k__BackingField
		}
		//public static class ObservedPlayerStateContext
		public readonly partial struct ObservedMovementController
		{
			public const uint Rotation = 0x20; //_Rotation_k__BackingField
			public const uint Velocity = 0xF0; //_velocity
		}
		//public static class ObservedPlayerHandsController
		public readonly partial struct ObservedHandsController
		{
			public const uint ItemInHands = 0x58; //_item
			public const uint BundleAnimationBones = 0xA8; //_bundleAnimationBones
		}
		//public static class BundleAnimationBones
		public readonly partial struct BundleAnimationBonesController
		{
			public const uint ProceduralWeaponAnimationObs = 0xD0; //_ProceduralWeaponAnimation_k__BackingField
		}
		//public static class ProceduralWeaponAnimation
		public readonly partial struct ProceduralWeaponAnimationObs
		{
			public const uint _isAimingObs = 0x145; //_isAiming
		}
		//public static class ObservedPlayerHealthController
		public readonly partial struct ObservedHealthController
		{
			public const uint Player = 0x18; //_player
			public const uint PlayerCorpse = 0x20; //_playerCorpse
			public const uint HealthStatus = 0x10;
		}
		//public static class ProceduralWeaponAnimation
        public readonly partial struct ProceduralWeaponAnimation
        {
            public const uint ShotNeedsFovAdjustments = 0x433;
            public const uint Breath = 0x38;
            public const uint PositionZeroSum = 0x31C;
            public const uint Shootingg = 0x58;
            public const uint _aimingSpeed = 0x164;
            public const uint _isAiming = 0x145;
            public const uint _optics = 0x180;
            public const uint _shotDirection = 0x1c8;
            public const uint Mask = 0x30;
            public const uint HandsContainer = 0x20;
            public const uint _fovCompensatoryDistance = 0x194;
			      		
        }
		//public static class PlayerSpring
		public readonly partial struct HandsContainer
		{
			public const uint CameraOffset = 0xDC;
            public const uint HandsRotation = 0x40;
            public const uint CameraRotation = 0x48;
            public const uint CameraPosition = 0x50;
		}
		//public static class SightNBone
		public readonly partial struct SightNBone
		{
			public const uint Mod = 0x10;
		}
		//public static class ShotEffector
		public readonly partial struct ShotEffector
		{
			public const uint NewShotRecoil = 0x20;
		}
		//public static class PlayerStateContainer
        public readonly partial struct PlayerStateContainer
        {
            public const uint Name = 0x19;
            public const uint StateFullNameHash = 0x40;
        }
		//public static class NewRecoilShotEffect
		public readonly partial struct NewShotRecoil
		{
			public const uint IntensitySeparateFactors = 0x94;
		}
		//public static class VisorEffect
		public readonly partial struct VisorEffect
		{
			public const uint Intensity = 0x20;
		}
		//public static class TOD_Time
		public readonly partial struct TOD_Time
		{
			public const uint LockCurrentTime = 0x20;
		}
		//public static class TOD_CycleParameters
		public readonly partial struct TOD_CycleParameters
		{
			public const uint Hour = 0x10;
		}
		//public static class TOD_ImageEffect
		public readonly partial struct TOD_Scattering
		{
			public const uint Sky = 0x28;  //_sky
		}
		//public static class TOD_Sky
		public readonly partial struct TOD_Sky
		{
			public const uint Cycle = 0x38; //_Cycle_k__BackingField
			public const uint TOD_Components = 0xA0; //_Components_k__BackingField
		}
		//public static class TOD_Components
		public readonly partial struct TOD_Components
		{
			public const uint TOD_Time = 0x118; //_Time_k__BackingField
		}
		//public static class Profile
		public readonly partial struct Profile
		{
			public const uint Id = 0x10;
			public const uint AccountId = 0x18;
			public const uint Info = 0x48;
			public const uint Inventory = 0x70;
			public const uint Skills = 0x80;
			public const uint TaskConditionCounters = 0x90;
			public const uint QuestsData = 0x98;
			public const uint WishlistManager = 0x108;
			public const uint Stats = 0x148;
		}
		//public static class WishlistManager
		public readonly partial struct WishlistManager
		{
			public const uint Items = 0x28; //_userItems
		}
		//public static class ProfileInfo
		public readonly partial struct PlayerInfo
		{
			public const uint Nickname = 0x10;
			public const uint EntryPoint = 0x28;
			public const uint Side = 0x48;
			public const uint RegistrationDate = 0x4C;
			public const uint GroupId = 0x50;
			public const uint Settings = 0x78;
			public const uint MemberCategory = 0x80;
			public const uint Experience = 0x84;
		}
		//public static class SkillManager
		public readonly partial struct SkillManager
		{
			public const uint StrengthBuffJumpHeightInc = 0x60;
			public const uint StrengthBuffThrowDistanceInc = 0x70;
			public const uint MagDrillsLoadSpeed = 0x180;
			public const uint MagDrillsUnloadSpeed = 0x188;
    		public const uint RaidLoadedAmmoAction   = 0x480;
    		public const uint RaidUnloadedAmmoAction = 0x488;
    		public const uint SpeedMultiplier = 0x30;
		}
		//public static class FloatBuff
		public readonly partial struct SkillValueContainer
		{
			public const uint Value = 0x30;
		}
		//public static class QuestStatusData
		public readonly partial struct QuestData
		{
			public const uint Id = 0x10;
			public const uint Status = 0x1C;
			public const uint CompletedConditions = 0x28;
			public const uint Template = 0x38;
		}
		//public static class CompletedConditionsCollection
		public readonly partial struct CompletedConditionsCollection
		{
			public const uint BackendData = 0x10; //_backendData
			public const uint LocalChanges = 0x18; //_localChanges
		}
		//public static class QuestTemplate
		public readonly partial struct QuestTemplate
		{
			public const uint Conditions = 0x60; //_Conditions_k__BackingField
			public const uint Name = 0xC8; //_questName
		}
		//?
		public readonly partial struct QuestConditionsContainer
		{
			public const uint ConditionsList = 0x70;
		}
		//public static class ItemHandsController
		public readonly partial struct ItemHandsController
		{
			public const uint Item = 0x70; //_item
		}
		//public static class FirearmController
		public readonly partial struct FirearmController
		{
			public const uint Fireport = 0x150;
			public const uint TotalCenterOfImpact = 0xF0; //COI
			public const uint WeaponLn = 0x100;
		}
		//public static class ClientFirearmController + public static class FirearmController
		public readonly partial struct ClientFirearmController
		{
			public const uint WeaponLn = 0x100; //from FirearmController
			public const uint ShotIndex = 0x438;
		}
		//public static class MovementContext
        public readonly partial struct MovementContext
        {
            public const uint Player = 0x48; //_player
            public const uint _rotation = 0xC8;
            public const uint PlantState = 0x78;
            public const uint CurrentState = 0x1F0; //_CurrentState_k__BackingField
            public const uint _states = 0x480;
            public const uint _movementStates = 0x4B0;
            public const uint _tilt = 0xB4;
            public const uint _physicalCondition = 0x198;
            public const uint _speedLimitIsDirty = 0x1B9;
            public const uint StateSpeedLimit = 0x1BC; //_StateSpeedLimit_k__BackingField
            public const uint StateSprintSpeedLimit = 0x1C0; //_StateSprintSpeedLimit_k__BackingField
            public const uint _lookDirection = 0x3B8;
            public const uint WalkInertia = 0x4bC; //_WalkInertia_k__BackingField
            public const uint SprintBrakeInertia = 0x4C0; //_SprintBrakeInertia_k__BackingField
            public const uint _poseInertia = 0x4C4;
			public const uint _currentPoseInertia = 0x4C8;
			public const uint _inertiaAppliedTime = 0x26C;			
        }
		//public static class MovementState + public static class BaseMovementState + public static class MovePlayerState
        public readonly partial struct MovementState
        {
            public const uint StickToGround = 0x54;//from MovementState
            public const uint PlantTime = 0x58; //from MovementState
            public const uint Name = 0x11; //from BaseMovementState
            public const uint AnimatorStateHash = 0x20; //from BaseMovementState
            public const uint _velocity = 0xDC; //from MovePlayerState
            public const uint _velocity2 = 0xF0; //from MovePlayerState
			public const uint AuthoritySpeed = 0x28; //from BaseMovementState
        }
		//public static class InventoryController
		public readonly partial struct InventoryController
		{
			public const uint Inventory = 0x100; //_Inventory_k__BackingField
		}
		//public static class Inventory
		public readonly partial struct Inventory
		{
			public const uint Equipment = 0x18;
			public const uint QuestRaidItems = 0x20;
			public const uint QuestStashItems = 0x28;
			public const uint Stash = 0x20;
		}
		//public static class Stash + ? might be using public static class CompoundItem
		public readonly partial struct Stash
		{
			public const uint Grids = 0x98;
			public const uint Slots = 0x80; //from CompoundItem
		}
		//public static class CompoundItem
		public readonly partial struct Equipment
		{
			public const uint Grids = 0x78;
			public const uint Slots = 0x80;
		}
		//public static class BarterOther
		public readonly partial struct BarterOtherOffsets
		{
			public const uint Dogtag = 0x80;
		}
		//public static class DogtagComponent
		public readonly partial struct DogtagComponent
		{
			public const uint Item = 0x10;
			public const uint GroupId = 0x18;
			public const uint AccountId = 0x20;
			public const uint ProfileId = 0x28;
			public const uint Nickname = 0x30;
			public const uint Side = 0x38;
			public const uint Level = 0x3c;
			public const uint Time = 0x40;
			public const uint Status = 0x48;
			public const uint KillerAccountId = 0x50;
			public const uint KillerProfileId = 0x58;
			public const uint KillerName = 0x60;
			public const uint WeaponName = 0x68;
			public const uint CarriedByGroupMember = 0x70;
		}
		//public static class Grid
		public readonly partial struct Grids
		{
			public const uint ContainedItems = 0x48; //_ItemCollection_k__BackingField
		}
		//public static class GridItemCollection
		public readonly partial struct GridContainedItems
		{
			public const uint Items = 0x18; //ItemsList
		}
		//public static class Slot
		public readonly partial struct Slot
		{
			public const uint ContainedItem = 0x48; //_ContainedItem_k__BackingField
			public const uint ID = 0x58; //_ID_k__BackingField
			public const uint Required = 0x18;
		}
		//public static class LootItem
		public readonly partial struct InteractiveLootItem
		{
			public const uint Item = 0xF0; //_item
		}
		//public static class Skeleton
		public readonly partial struct DizSkinningSkeleton
		{
			public const uint _values = 0x30;
		}
		//public static class LootableContainer + public static class WorldInteractiveObject
		public readonly partial struct LootableContainer
		{
			public const uint InteractingPlayer = 0x150; //from WorldInteractiveObject _InteractingPlayer_k__BackingField
			public const uint ItemOwner = 0x168;
			public const uint Template = 0x170;
		}
		//public static class ItemController
		public readonly partial struct LootableContainerItemOwner
		{
			public const uint RootItem = 0xD0; //_RootItem_k__BackingField
		}
		//public static class Item
		public readonly partial struct LootItem
		{
			public const uint StackObjectsCount = 0x24;
			public const uint Version = 0x28;
    		public const uint Components = 0x40;
			public const uint Template = 0x60;
			public const uint SpawnedInSession = 0x68;
		}
		//public static class CompoundItem
		public readonly partial struct LootItemMod
		{
			public const uint Grids = 0x78;
			public const uint Slots = 0x80;
		}
		//public static class Grid
		public readonly partial struct Grid
		{
			public const uint ItemCollection = 0x48; //_ItemCollection_k__BackingField
		}
		//public static class GridItemCollection
		public readonly partial struct GridItemCollection
		{
		    public const uint ItemsList = 0x18;
		}
		//public static class Weapon
		public readonly partial struct LootItemWeapon
		{
			public const uint FireMode = 0xA0;
			public const uint Chambers = 0xB0; //_Chambers_k__BackingField
			public const uint _magSlotCache = 0xC8;
		}
		//public static class LevelSettings
        public readonly partial struct LevelSettings
        {
            public const uint AmbientMode = 0x60;
            public const uint EquatorColor = 0x74;
            public const uint GroundColor = 0x84;
        }
		//public static class SlotView_2
		public readonly partial struct PlayerBodySubclass
		{
			public const uint Dresses = 0x40;
		}
		//public static class Dress
		public readonly partial struct Dress
		{
			public const uint Renderers = 0x38;
		}
		//?
		public readonly partial struct SlotViewsContainer
		{
			public const uint Dict = 0x10;
		}
		public readonly partial struct EFT
		{
			//public static class EFTHardSettings
			public readonly partial struct EFTHardSettings
			{
				public const uint POSE_CHANGING_SPEED = 0x380;
				public const uint _instance = 0x0;
				public const uint MED_EFFECT_USING_PANEL = 0x3B4;
				public const uint MOUSE_LOOK_HORIZONTAL_LIMIT = 0x340;
				public const uint MOUSE_LOOK_LIMIT_IN_AIMING_COEF = 0x350;
				public const uint MOUSE_LOOK_VERTICAL_LIMIT = 0x348;
				public const uint ABOVE_OR_BELOW = 0x204;
				public const uint ABOVE_OR_BELOW_STAIRS = 0x20C;
				public const uint AIM_PROCEDURAL_INTENSITY = 0x3FC;
				public const uint AIR_CONTROL_BACK_DIR = 0x15C;
				public const uint AIR_CONTROL_NONE_OR_ORT_DIR = 0x160;
				public const uint AIR_CONTROL_SAME_DIR = 0x158;
				public const uint AIR_LERP = 0x3AC;
				public const uint AIR_MIN_SPEED = 0x3A8;
				public const uint DecelerationSpeed = 0x50;
				public const uint WEAPON_OCCLUSION_LAYERS = 0x238;
				public const uint DOOR_RAYCAST_DISTANCE = 0x18C;
				public const uint LOOT_RAYCAST_DISTANCE = 0x188;
			}
			//public static class EftScreenManager
			public readonly partial struct EftScreenManager
			{
				public const uint _instance = 0x0;
			}
			//public static class WeatherController
			public readonly partial struct WeatherController
			{
				public const uint Instance = 0x0;
			}
			//public static class GPUInstancerManager
			public readonly partial struct GPUInstancerManager
			{
				public const uint Instance = 0x0;
				public const uint runtimeDataList = 0x58;
			}
			//public static class ClientBackendSession
			public readonly partial struct ClientBackendSession
			{
				public const uint BackEndConfig = 0x158; //_BackEndConfig_k__BackingField
			}
		}
		//?
		public readonly partial struct BSGGameSettingValueClass
		{
			public const uint Value = 0x30;
		}
		//?
		public readonly partial struct BSGGameSetting
		{
			public const uint ValueClass = 0x28;
		}
		//public static class FireModeComponent
		public readonly partial struct FireModeComponent
		{
			public const uint FireMode = 0x28;
		}
		//public static class MagazineTemplate
		public readonly partial struct LootItemMagazine
		{
			public const uint Cartridges = 0xA8;
			public const uint LoadUnloadModifier = 0x1B0;
		}
		//public static class Item
		public readonly partial struct MagazineClass
		{
			public const uint StackObjectsCount = 0x24;
		}
		//public static class StackSlot
		public readonly partial struct StackSlot
		{
			public const uint _items = 0x18;
			public const uint MaxCount = 0x10;
		}
		//public static class ItemTemplate
		public readonly partial struct ItemTemplate
		{
			public const uint Name = 0x10;
			public const uint ShortName = 0x18;
			public const uint _id = 0xE0;
			public const uint Weight = 0xB0;
			public const uint QuestItem = 0x34;
		}
		//public static class ModTemplate
		public readonly partial struct ModTemplate
		{
			public const uint Velocity = 0x188;
		}
		//public static class AmmoTemplate
		public readonly partial struct AmmoTemplate
		{
			public const uint InitialSpeed = 0x1A4;
			public const uint BallisticCoeficient = 0x1B8;
			public const uint BulletMassGram = 0x25C;
			public const uint BulletDiameterMilimeters = 0x260;
		}
		//public static class WeaponTemplate
		public readonly partial struct WeaponTemplate
		{
			public const uint Velocity = 0x254;
            public const uint AllowJam = 0x308;
            public const uint AllowFeed = 0x309;
            public const uint AllowMisfire = 0x30A;
            public const uint AllowSlide = 0x30B;			
		}
		//public static class PlayerBody
		public readonly partial struct PlayerBody
		{
			public const uint SkeletonRootJoint = 0x30;
			public const uint BodySkins = 0x58;
			public const uint _bodyRenderers = 0x68;
			public const uint SlotViews = 0x90;
			public const uint PointOfView = 0xC0;
		}
		//public static class InventoryBlur
        public readonly partial struct InventoryBlur
        {
            public const uint _blurCount = 0x38;
            public const uint _upsampleTexDimension = 0x30;
        }
		//public static class Physical
        public readonly partial struct Physical
        {
            public const uint Overweight = 0x1C;
            public const uint WalkOverweight = 0x20;
            public const uint WalkSpeedLimit = 0x24;
            public const uint Inertia = 0x28;
            public const uint Stamina = 0x68;
            public const uint Oxygen = 0x78;
            public const uint BaseOverweightLimits = 0xAC;
            public const uint SprintOverweightLimits = 0xC0;
			public const uint SprintWeightFactor = 0x104;
            public const uint PreviousWeight = 0xD4;
            public const uint SprintAcceleration = 0x114;
            public const uint PreSprintAcceleration = 0x118;
			public const uint _encumbered = 0x11C;
            public const uint _overEncumbered = 0x11D;
			public const uint SprintOverweight = 0xD0;
			public const uint BerserkRestorationFactor = 0x110;
        }
		//public static class Stamina
        public readonly partial struct PhysicalValue //Class: .Stamina
        {
            public const uint Current = 0x10;
        }
		//public static class BreathEffector
        public readonly partial struct BreathEffector //Class: EFT.Animations.BreathEffector
        {
            public const uint Intensity = 0x30;
        }
		//public static class OpticCameraManager
		public readonly partial struct OpticCameraManager
		{
			public const uint Camera = 0x70;
			public const uint CurrentOpticSight = 0x78;
		}
		//public static class GPUInstancerRuntimeData
		public readonly partial struct GPUInstancerRuntimeData
        {
            public const uint instanceBounds = 0x20;
        }
		//public static class CameraManager
		public readonly partial struct EFTCameraManager
		{
			public const uint OpticCameraManager = 0x10;
			public const uint Camera = 0x60;
            public const uint GetInstance_RVA = 0x2CF8AB0;
            public const uint CameraDerefOffset = 0x10;
		}
		//public static class SightComponent
		public readonly partial struct SightComponent
		{
			public const uint _template = 0x20;
			public const uint ScopesSelectedModes = 0x30;
			public const uint SelectedScope = 0x38;
			public const uint ScopeZoomValue = 0x3C;
		}
		//public static class SightModTemplate
		public readonly partial struct SightInterface
		{
			public const uint Zooms = 0x1B8;
		}
		//public static class WeatherController
        public readonly partial struct WeatherController
        {
            public const uint WeatherDebug = 0x88;
        }
		//public static class WeatherDebug
        public readonly partial struct WeatherDebug
        {
            public const uint CloudDensity = 0x24;
            public const uint Fog = 0x28;
            public const uint LightningThunderProbability = 0x30;
            public const uint Rain = 0x2c;
            public const uint WindMagnitude = 0x14;
            public const uint isEnabled = 0x10;
        }
		//
        public readonly partial struct Special
        {
            public const ulong TypeInfoTableRva = 0x5AA9118;
            public const uint EFTHardSettings_TypeIndex = 225;
            public const uint GPUInstancerManager_TypeIndex = 4917;
            public const uint WeatherController_TypeIndex = 10104;
            public const uint GlobalConfiguration_TypeIndex = 6406;
        }
		public readonly partial struct Il2CppClass
		{
			public const uint Name         = 0x10;
			public const uint Namespace    = 0x18;
			public const uint Fields       = 0x80;
			public const uint StaticFields = 0xB8;
			public const uint Methods      = 0x98;
			public const uint MethodCount  = 0x120;
			public const uint FieldCount   = 0x124;
		}
	}

	public readonly partial struct Enums
	{
		public enum EPlayerState
		{
			None = 0,
			Idle = 1,
			ProneIdle = 2,
			ProneMove = 3,
			Run = 4,
			Sprint = 5,
			Jump = 6,
			FallDown = 7,
			Transition = 8,
			BreachDoor = 9,
			Loot = 10,
			Pickup = 11,
			Open = 12,
			Close = 13,
			Unlock = 14,
			Sidestep = 15,
			DoorInteraction = 16,
			Approach = 17,
			Prone2Stand = 18,
			Transit2Prone = 19,
			Plant = 20,
			Stationary = 21,
			Roll = 22,
			JumpLanding = 23,
			ClimbOver = 24,
			ClimbUp = 25,
			VaultingFallDown = 26,
			VaultingLanding = 27,
			BlindFire = 28,
			IdleWeaponMounting = 29,
			IdleZombieState = 30,
			MoveZombieState = 31,
			TurnZombieState = 32,
			StartMoveZombieState = 33,
			EndMoveZombieState = 34,
			DoorInteractionZombieState = 35,
		}

		[Flags]
		public enum EMemberCategory
		{
			Default = 0,
			Developer = 1,
			UniqueId = 2,
			Trader = 4,
			Group = 8,
			System = 16,
			ChatModerator = 32,
			ChatModeratorWithPermanentBan = 64,
			UnitTest = 128,
			Sherpa = 256,
			Emissary = 512,
			Unheard = 1024,
		}

		public enum WildSpawnType
		{
			marksman = 0,
			assault = 1,
			bossTest = 2,
			bossBully = 3,
			followerTest = 4,
			followerBully = 5,
			bossKilla = 6,
			bossKojaniy = 7,
			followerKojaniy = 8,
			pmcBot = 9,
			cursedAssault = 10,
			bossGluhar = 11,
			followerGluharAssault = 12,
			followerGluharSecurity = 13,
			followerGluharScout = 14,
			followerGluharSnipe = 15,
			followerSanitar = 16,
			bossSanitar = 17,
			test = 18,
			assaultGroup = 19,
			sectantWarrior = 20,
			sectantPriest = 21,
			bossTagilla = 22,
			followerTagilla = 23,
			exUsec = 24,
			gifter = 25,
			bossKnight = 26,
			followerBigPipe = 27,
			followerBirdEye = 28,
			bossZryachiy = 29,
			followerZryachiy = 30,
			bossBoar = 32,
			followerBoar = 33,
			arenaFighter = 34,
			arenaFighterEvent = 35,
			bossBoarSniper = 36,
			crazyAssaultEvent = 37,
			peacefullZryachiyEvent = 38,
			sectactPriestEvent = 39,
			ravangeZryachiyEvent = 40,
			followerBoarClose1 = 41,
			followerBoarClose2 = 42,
			bossKolontay = 43,
			followerKolontayAssault = 44,
			followerKolontaySecurity = 45,
			shooterBTR = 46,
			bossPartisan = 47,
			spiritWinter = 48,
			spiritSpring = 49,
			peacemaker = 50,
			pmcBEAR = 51,
			pmcUSEC = 52,
			skier = 53,
			sectantPredvestnik = 57,
			sectantPrizrak = 58,
			sectantOni = 59,
			infectedAssault = 60,
			infectedPmc = 61,
			infectedCivil = 62,
			infectedLaborant = 63,
			infectedTagilla = 64,
			bossTagillaAgro = 65,
			bossKillaAgro = 66,
			tagillaHelperAgro = 67,
		}

		public enum EExfiltrationStatus
		{
			NotPresent = 1,
			UncompleteRequirements = 2,
			Countdown = 3,
			RegularMode = 4,
			Pending = 5,
			AwaitsManualActivation = 6,
			Hidden = 7,
		}

		[Flags]
		public enum EProceduralAnimationMask
		{
			Breathing = 1,
			Walking = 2,
			MotionReaction = 4,
			ForceReaction = 8,
			Shooting = 16,
			DrawDown = 32,
			Aiming = 64,
			HandShake = 128,
		}

		public enum SynchronizableObjectType
		{
			AirDrop = 0,
			AirPlane = 1,
			Tripwire = 2,
		}

		public enum ETripwireState
		{
			None = 0,
			Wait = 1,
			Active = 2,
			Exploding = 3,
			Exploded = 4,
			Inert = 5,
		}

	}
}