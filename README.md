# AV-Sketch

**AV-Sketch** is a virtual reality (VR) design tool that empowers designers and novices to brainstorm automotive UIs, enabling them to refine and validate early design concepts for AV-passenger interactions. This repository contains the Unity project files for the implemented design scenarios. 

**To run the project on your local machine:**

1. **Open the project folder through Unity Hub:** 
    - The version needed is 2018.4.14f1.

2. **To build the project in a Meta Quest Headset:**
    - Go to **File** --> **Build Settings**.
    - Choose the Platform as **"Android"** and set Texture Compression to **"ASTC."**
    - *(Optional)* Based on your settings, you may also need to change this: 
        - Go to **File** --> **Build Settings** --> **Player Settings** --> **Other Settings** --> **Configuration** --> **Scripting Backend** --> **Mono** (currently set as **"IL2CPP"**).

For more details about the project, please read the full paper here: [https://doi.org/10.1145/3640792.3675705](https://doi.org/10.1145/3640792.3675705).

---
