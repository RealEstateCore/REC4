[Asset](../../../Asset.md) > [Equipment](../../Equipment.md) > [HVAC_Equipment](../HVAC_Equipment.md) > [Air_Plenum](Air_Plenum.md) > [Discharge_Air_Plenum](.)
# Discharge_Air_Plenum
**DTMI:** dtmi:org:brickschema:schema:Brick:Discharge_Air_Plenum;1
## Display name
- **en:** Discharge Air Plenum
## Description
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Equipment;1:** feeds, isFedBy
* **dtmi:org:w3id:rec:Asset;1:** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Equipment;1:** operationalStageCount
* **dtmi:org:w3id:rec:Asset;1:** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight
## Target Of
### Inherited
* Asset.hasPart
* Asset.isPartOf
* EquipmentCollection.includes