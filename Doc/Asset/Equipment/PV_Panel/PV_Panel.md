[Asset](../../Asset.md) > [Equipment](../Equipment.md) > [PV_Panel](.)
# PV_Panel

**Display name:** PV Panel<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:PV_Panel;1

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Equipment;1:** feeds, isFedBy
* **dtmi:org:w3id:rec:Asset;1:** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|measuredModuleConversionEfficiency|**en**: Measured module conversion efficiency||Microsoft.Azure.DigitalTwins.Parser.Models.DTObjectInfo|True|
|ratedModuleConversionEfficiency|**en**: Rated module conversion efficiency||Microsoft.Azure.DigitalTwins.Parser.Models.DTObjectInfo|True|
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Equipment;1:** operationalStageCount
* **dtmi:org:w3id:rec:Asset;1:** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight
## Target Of
### Inherited
* Asset.hasPart
* Asset.isPartOf
* EquipmentCollection.includes
