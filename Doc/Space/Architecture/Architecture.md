# Architecture
**DTMI:** dtmi:org:w3id:rec:Architecture;1
## Display name
- **en:** Architecture
## Description
- **en:** A designed/landscaped (or potentially designed/landscaped) part of the physical world that has a 3D spatial extent. E.g., a building site, a building, levels within the building, rooms, etc.
## Relationships
|Name|Display name|Description|Multiplicity|Target|Properties|
|-|-|-|-|-|-|
|address|**en**: address|**en**: Physical address of the architecture (site, building, sub-building, entrance room, etc.) in question.|0-Infinity|dtmi:org:w3id:rec:PostalAddress;1|
|adjacentElement|**en**: adjacent element||0-Infinity|dtmi:org:w3id:rec:BuildingElement;1|
|architectedBy|**en**: architected by||0-Infinity|dtmi:org:w3id:rec:Agent;1|
|constructedBy|||0-Infinity|dtmi:org:w3id:rec:Agent;1|
|containsElement|**en**: contains element|**en**: Links an Architecture to BuildingElement that is contained in the Space.|0-Infinity|dtmi:org:w3id:rec:BuildingElement;1|
|documentation|**en**: documentation||0-Infinity|dtmi:org:w3id:rec:Document;1|
|hasPoint|**en**: has point||0-Infinity|dtmi:org:brickschema:schema:Brick:Point;1|
|intersectingElement|**en**: intersecting element||0-Infinity|dtmi:org:w3id:rec:BuildingElement;1|
|isFedBy|**en**: is fed by||0-Infinity||substance (schema: TBD)
|operatedBy|**en**: operated by||0-Infinity|dtmi:org:w3id:rec:Agent;1|
|ownedBy|**en**: owned by||0-Infinity|dtmi:org:w3id:rec:Agent;1|
## Properties
## Telemetries
## Commands
