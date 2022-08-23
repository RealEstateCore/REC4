# Equipment
**DTMI:** dtmi:org:brickschema:schema:Brick:Equipment;1
## Display name
- **en:** Equipment
## Description
## Relationships
|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|feeds|**en**: feeds||0-Infinity||substance (schema: TBD)|True|
|isFedBy|**en**: is fed by||0-Infinity||substance (schema: TBD)|True|
### Inherited Relationships
* **dtmi:org:w3id:rec:Asset;1:** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|operationalStageCount|**en**: Operational stage count||TBD|True|
### Inherited Properties
* **dtmi:org:w3id:rec:Asset;1:** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight
## Target Of
* EquipmentCollection.includes
## Inherited Target Of
* Asset.hasPart
* Asset.isPartOf
