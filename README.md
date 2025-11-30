# 🚪 The Cubicle Escape – VR Interaction Demo

https://github.com/user-attachments/assets/a604d5df-8ff2-4507-b1a2-a8703a9be795

### Built with **Unity 6.2** | **XR Interaction Toolkit** | **ProBuilder** | **XR Device Simulator**

This project demonstrates core VR interaction mechanics in a virtual cubicle environment, including locomotion, physics object interaction, UI interaction, and scoring with audio feedback.

---

## 🎮 Project Overview
The goal of this project is to build an interactive virtual room where players can move around, grab and throw objects, interact with UI using VR rays, and complete a simple gameplay task involving a scoring bin.

---

## ✨ Features & Functionalities

### **1️⃣ 3D Room Environment**
- Designed a realistic room setup with lighting and furniture.
- Used ProBuilder to construct walls, floors, table surfaces, and bin structure.

### **2️⃣ Locomotion**
- Implemented **Teleportation Locomotion** using the XR Interaction Toolkit.
- Used **XR Device Simulator** to test interactions without an actual headset.
- Collision handling ensures players cannot move through walls or objects.

### **3️⃣ Physics & Object Grabbing**
- Placed **three cubes** on a table as interactable objects.
- Cubes can be **grabbed using virtual hands** (Direct Interactor).
- They can be **thrown**, reacting with physics, gravity, and bounce.
- **Ray Interactor** also supports grabbing from a distance.

### **4️⃣ UI Interaction**
- Created a **World Space Canvas** with a **floating button**.
- Button pressed using Ray Interaction triggers:
  - Random **color change** to all cubes.

### **5️⃣ Bin Scoring Game Logic**
- Constructed a **bin** area where cubes can be thrown.
- Added a **trigger collider** at the base of the bin.
- When a cube enters the bin:
  - A **sound effect** plays.
  - A **TextMeshPro score display** increases: `1 → 2 → 3...`

---

## 🛠 Tools & Packages Used

| Feature | Tools / Packages |
|--------|------------------|
| Game Engine | Unity 6.2 |
| Scene Modeling | ProBuilder |
| VR Interaction | XR Interaction Toolkit |
| Testing | XR Device Simulator |
| UI Text | TextMeshPro |
| Physics | Rigidbody & Colliders |
| Audio | Unity AudioSource System |

---
