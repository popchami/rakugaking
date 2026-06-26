# NEXT_TASK

## Project

rakugaking

## Current Phase

Implementation Preparation

## Current Unity Implementation Phase

Phase 0 - Project Setup

## Completed Previous Task

Unity project structure has been decided.

```text
rakugaking/
├── PROJECT_STATE.md
├── HANDOFF.md
├── NEXT_TASK.md
├── docs/
└── unity/
    └── Rakugaking/
```

A Unity project folder guide has been added at:

```text
unity/Rakugaking/README.md
```

A Codex prompt for Unity initialization has been added at:

```text
docs/CODEX_UNITY_INIT_PROMPT.md
```

## Next Task

Initialize the Unity project in `unity/Rakugaking/` using an environment that can run Unity.

## Important Note

GitHub file creation alone cannot fully create and verify a real Unity project.

This task requires Unity Editor, Unity Hub, Unity command line, Codex with Unity support, or another environment that can create/open Unity projects.

## Goal

Create the initial Unity project files in the decided folder so Unity development can begin.

## Scope

This task may include:

- Confirming Unity version
- Confirming project template
- Creating the Unity project in `unity/Rakugaking/`
- Verifying the project opens in Unity
- Verifying Play mode starts
- Verifying there are no red Console errors

## Out of Scope

Do not implement gameplay yet.

Do not create battle systems yet.

Do not create character drawing systems yet.

Do not create UI systems yet.

Do not add multiple new specification documents.

## Proposed Direction

Use a stable Unity LTS version available in the development environment.

Use a 3D project template because rakugaking is intended to involve 3D characters and physics-based chaotic movement.

## Done Conditions

This task is complete when:

- Unity project files exist under `unity/Rakugaking/`
- The project can be opened in Unity
- Unity Play mode can start
- There are no red Console errors in the initial empty scene

## Owner Check

The owner only needs to confirm:

- Unity opens the project
- Play button works
- No red Console errors appear

## Next Task After This

Create the minimum playable foundation scene.
