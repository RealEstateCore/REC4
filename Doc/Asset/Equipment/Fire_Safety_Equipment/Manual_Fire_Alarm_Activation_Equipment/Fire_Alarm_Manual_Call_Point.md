[Asset](../../../Asset.md) > [Equipment](../../Equipment.md) > [Fire_Safety_Equipment](../Fire_Safety_Equipment.md) > [Manual_Fire_Alarm_Activation_Equipment](Manual_Fire_Alarm_Activation_Equipment.md) > [Fire_Alarm_Manual_Call_Point](.)
# Fire_Alarm_Manual_Call_Point
**DTMI:** dtmi:org:brickschema:schema:Brick:Fire_Alarm_Manual_Call_Point;1
## Display name
- **en:** Fire Alarm Manual Call Point
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