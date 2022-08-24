[Space](../../Space.md) > [Architecture](../Architecture.md) > [Level](#)
# Level

The level of a building, a.k.a. storey, floor, etc.


**Display name:** Level<br />
**DTMI:** dtmi:org:w3id:rec:Level;1

---


## Child interfaces
* [BasementLevel](BasementLevel.md)
* [MezzanineLevel](MezzanineLevel.md)
* [RoofLevel](RoofLevel.md)

---
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
