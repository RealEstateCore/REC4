# BuildingElement
**DTMI:** dtmi:org:w3id:rec:BuildingElement;1
## Display name
- **en:** Building element
## Description
- **en:** A part that constitutes a piece of a building's structural makeup. E.g., Facade, Wall, Slab, Roof, etc.
## Relationships
|Name|Display name|Description|Multiplicity|Target|Properties|
|-|-|-|-|-|-|
|documentation|**en**: documentation||0-Infinity|dtmi:org:w3id:rec:Document;1|
|hasPart|**en**: has part||0-Infinity|dtmi:org:w3id:rec:BuildingElement;1|
|isPartOf|**en**: is part of||0-1|dtmi:org:w3id:rec:BuildingElement;1|
|locatedIn|**en**: located in|**en**: Indicates the architected space (site, building, level, room...) in which this building element is placed.|0-1|dtmi:org:w3id:rec:Architecture;1|
## Properties
|Name|Display name|Description|Schema|Writeable|
|-|-|-|-|-|
|customTags|**en**: Custom Tags||TBD|True
|externalIds|**en**: External IDs||TBD|True
|name|**en**: name||TBD|True
## Telemetries
## Commands
