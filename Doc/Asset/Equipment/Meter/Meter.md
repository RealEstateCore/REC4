[Asset](../../Asset.md) > [Equipment](../Equipment.md) > [Meter](.)
# Meter
**DTMI:** dtmi:org:brickschema:schema:Brick:Meter;1
## Display name
- **en:** Meter
## Description
## Relationships
|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|hasSubMeter|**en**: has sub-meter||0-Infinity|dtmi:org:brickschema:schema:Brick:Meter;1||True|
|isSubMeterOf|**en**: is sub-meter of||0-Infinity|dtmi:org:brickschema:schema:Brick:Meter;1||True|
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Equipment;1:** feeds, isFedBy
* **dtmi:org:w3id:rec:Asset;1:** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|isMeteredBy|**en**: is metered by||string|True|
|isVirtualMeter|**en**: is virtual meter||boolean|True|
|meters|**en**: meters||string|True|
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Equipment;1:** operationalStageCount
* **dtmi:org:w3id:rec:Asset;1:** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight
## Target Of
### Direct
* Meter.hasSubMeter
* Meter.isSubMeterOf
### Inherited
* Asset.hasPart
* Asset.isPartOf
* EquipmentCollection.includes
