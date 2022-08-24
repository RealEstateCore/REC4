[Space](../../Space.md) > [Architecture](../Architecture.md) > [Level](.)
# Level
**DTMI:** dtmi:org:w3id:rec:Level;1
## Display name
- **en:** Level
## Description
- **en:** The level of a building, a.k.a. storey, floor, etc.
## Relationships
### Inherited Relationships
* **dtmi:org:w3id:rec:Architecture;1:** address, adjacentElement, architectedBy, constructedBy, containsElement, documentation, hasPoint, intersectingElement, isFedBy, operatedBy, ownedBy
* **dtmi:org:w3id:rec:Space;1:** hasPart, isLocationOf, isPartOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|levelNumber|**en**: level number||integer|True|
### Inherited Properties
* **dtmi:org:w3id:rec:Space;1:** customTags, externalIds, geometry, name
## Target Of
### Inherited
* Asset.locatedIn
* BuildingElement.locatedIn
* Space.hasPart
* Space.isPartOf
* Campus.includes
