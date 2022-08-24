[Asset](../../../Asset.md) > [Equipment](../../Equipment.md) > [HVAC_Equipment](../HVAC_Equipment.md) > [AHU](.)
# AHU

**Display name:** AHU<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:AHU;1

---


## Child interfaces
* [DDAHU](DDAHU.md)
* [Dedicated_Outdoor_Air_System_Unit](Dedicated_Outdoor_Air_System_Unit.md)
* [DOAS](DOAS.md)
* [Dual_Duct_Air_Handling_Unit](Dual_Duct_Air_Handling_Unit.md)
* [Makeup_Air_Unit](Makeup_Air_Unit.md)
* [MAU](MAU.md)
* [PAU](PAU.md)
* [Rooftop_Unit](Rooftop_Unit.md)
* [RTU](RTU.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Equipment;1:** feeds, isFedBy
* **dtmi:org:w3id:rec:Asset;1:** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy
## Properties
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Equipment;1:** operationalStageCount
* **dtmi:org:w3id:rec:Asset;1:** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight
## Target Of
### Inherited
* Asset.hasPart
* Asset.isPartOf
* EquipmentCollection.includes
