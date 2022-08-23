# Asset
**DTMI:** dtmi:org:w3id:rec:Asset;1
## Display name
- **en:** Asset
## Description
- **en:** Something which is placed inside of a building, but is not an integral part of that building's structure; e.g., furniture, equipment, systems, etc.
## Relationships
|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|commissionedBy|**en**: commissioned by||0-Infinity|dtmi:org:w3id:rec:Agent;1||True|
|documentation|**en**: documentation||0-Infinity|dtmi:org:w3id:rec:Document;1||True|
|hasPart|**en**: has part||0-Infinity|dtmi:org:w3id:rec:Asset;1||True|
|hasPoint|**en**: has point||0-Infinity|dtmi:org:brickschema:schema:Brick:Point;1||True|
|installedBy|**en**: installed by||0-Infinity|dtmi:org:w3id:rec:Agent;1||True|
|isPartOf|**en**: is part of||0-Infinity|dtmi:org:w3id:rec:Asset;1||True|
|locatedIn|**en**: located in||0-Infinity|dtmi:org:w3id:rec:Space;1||True|
|manufacturedBy|**en**: manufactured by||0-Infinity|dtmi:org:w3id:rec:Agent;1||True|
|mountedOn|**en**: mounted on|**en**: An asset may be mounted on some part of the building construction (e.g., a blind on a facade, a camera on a wall, etc).|0-1|dtmi:org:w3id:rec:BuildingElement;1||True|
|servicedBy|**en**: serviced by||0-Infinity|dtmi:org:w3id:rec:Agent;1||True|
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|IPAddress|**en**: IP address||TBD|True|
|MACAddress|**en**: MAC address||TBD|True|
|assetTag|**en**: asset tag||TBD|True|
|commissioningDate|**en**: commissioning date||TBD|True|
|customTags|**en**: Custom Tags||TBD|True|
|externalIds|**en**: External IDs||TBD|True|
|geometry|**en**: geometry|**en**: A GeoJSON Polygon coordinate listing representing the geometrical representation of the asset. Coordinates may be expressed in two or three dimensions. Ex: [[30.0, 10.0, 0.0], [40.0, 40.0, 2.0], [20.0, 40.0, 2.0], [10.0, 20.0, 2.0], [30.0, 10.0, 0.0]].|TBD|True|
|initialCost|**en**: initial cost||TBD|True|
|installationDate|**en**: installation date||TBD|True|
|maintenanceInterval|**en**: maintenance interval||TBD|True|
|modelNumber|**en**: model number||TBD|True|
|name|**en**: name||TBD|True|
|serialNumber|**en**: serial number||TBD|True|
|turnoverDate|**en**: turnover date||TBD|True|
|weight|**en**: weight||TBD|True|
## Target Of
### Direct
* Asset.hasPart
* Asset.isPartOf
