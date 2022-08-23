# Meter
**DTMI:** dtmi:org:brickschema:schema:Brick:Meter;1
## Display name
- **en:** Meter
## Description
## Relationships
|Name|Display name|Description|Multiplicity|Target|Properties|
|-|-|-|-|-|-|
|hasSubMeter|**en**: has sub-meter||0-Infinity|dtmi:org:brickschema:schema:Brick:Meter;1|
|isSubMeterOf|**en**: is sub-meter of||0-Infinity|dtmi:org:brickschema:schema:Brick:Meter;1|
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Equipment;1:** feeds, isFedBy
* **dtmi:org:w3id:rec:Asset;1:** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy
## Properties
|Name|Display name|Description|Schema|Writeable|
|-|-|-|-|-|
|isMeteredBy|**en**: is metered by||TBD|True
|isVirtualMeter|**en**: is virtual meter||TBD|True
|meters|**en**: meters||TBD|True
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Equipment;1:** operationalStageCount
* **dtmi:org:w3id:rec:Asset;1:** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight
## Telemetries
## Commands
