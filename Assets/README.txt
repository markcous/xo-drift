Assets/
├── Art/                        # All imported art assets
│   ├── Characters/            # 2D sprites, textures, meshes for captains & crew
│   ├── Ships/                 # ship models, textures, icons
│   ├── Environments/          # background art, skyboxes, props
│   └── UI/                    # button graphics, icons, fonts
│
├── Audio/                      # music & SFX
│   ├── Music/                 
│   └── SFX/                   
│
├── Materials/                  # material assets (by shader/type)
│
├── Prefabs/                    # all prefab variants
│   ├── UI/                     # window, button, panel prefabs
│   ├── Captains/               # captain card prefabs
│   ├── Ships/                  
│   ├── Crew/                   
│   └── Misc/                   
│
├── Scenes/                     # Unity scenes
│   ├── Config.unity           
│   ├── Mission.unity          
│   └── End.unity              
│
├── Scripts/                    # C# source
│   ├── Core/                   # GameState, SaveManager, etc.
│   ├── Data/                   # models & ScriptableObject definitions
│   ├── StateMachine/           # MissionStateMachine & state classes
│   ├── UI/                     # UI controllers (ConfigScreenController, etc.)
│   └── Utilities/              # helpers, extensions
│
├── Data/                       # runtime data assets
│   └── ScriptableObjects/      # CaptainData, ShipData, RouteData, etc.
│
├── Addressables/               # if using Addressables, grouping & settings
│
├── Plugins/                    # 3rd-party SDKs & packages outside Package Manager
│
├── Resources/                  # (use sparingly!) for dynamic Resources.Load calls
│
└── Editor/                     # custom editor scripts & inspectors

Root Assets folder. Contains all game assets organized into categories like art, audio, scripts, etc.