[BuildingElement](.)
# BuildingElement
**DTMI:** dtmi:org:w3id:rec:BuildingElement;1
## Display name
- **en:** Building element
## Description
- **en:** A part that constitutes a piece of a building's structural makeup. E.g., Facade, Wall, Slab, Roof, etc.
## Relationships
|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|documentation|**en**: documentation||0-Infinity|dtmi:org:w3id:rec:Document;1||True|
|hasPart|**en**: has part||0-Infinity|dtmi:org:w3id:rec:BuildingElement;1||True|
|isPartOf|**en**: is part of||0-1|dtmi:org:w3id:rec:BuildingElement;1||True|
|locatedIn|**en**: located in|**en**: Indicates the architected space (site, building, level, room...) in which this building element is placed.|0-1|dtmi:org:w3id:rec:Architecture;1||True|
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|customTags|**en**: Custom Tags||map (string->boolean)|True|
|externalIds|**en**: External IDs||map (string->string)|True|
|name|**en**: name||string|True|
## Target Of
### Direct
* Asset.mountedOn
* BuildingElement.hasPart
* BuildingElement.isPartOf
* Architecture.adjacentElement
* Architecture.containsElement
* Architecture.intersectingElement
