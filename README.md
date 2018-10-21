# ARCoreUtils - Essentials

Unity plugin that provides collision to ARCore tracked planes. For ARCore 1.3+ 

## Getting Started

* Drag the SurfaceManager prefab into the scene from the Neuston folder.
* Deploy to device.

## Features

### Collision

It's helpful to have objects in the virtual scene collide with the ground of the real scene.

The ARCore SDK's trackable planes are essentially identified flat surfaces such as the ground or a tabletop. 

ARCoreUtils asks the SDK for a list of points in each trackable plane's boundary polygon (retrieved in clockwise order). A mesh is created for these points via triangulation. With the mesh ready, we create a GameObject and add a MeshCollider component that references it.

### Shadows

To be added.
