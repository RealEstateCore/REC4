# Building_Water_Meter
**DTMI:** dtmi:org:brickschema:schema:Brick:Building_Water_Meter;1
## Display name
- **en:** Building Water Meter
## Description
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Meter;1:** hasSubMeter, isSubMeterOf
* **dtmi:org:brickschema:schema:Brick:Equipment;1:** feeds, isFedBy
* **dtmi:org:w3id:rec:Asset;1:** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|TBD|False|
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Meter;1:** isMeteredBy, isVirtualMeter, meters
* **dtmi:org:brickschema:schema:Brick:Equipment;1:** operationalStageCount
* **dtmi:org:w3id:rec:Asset;1:** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight
## Inherited Target Of
* Asset.hasPart
* Asset.isPartOf
* EquipmentCollection.includes
* Meter.hasSubMeter
* Meter.isSubMeterOf
