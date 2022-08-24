[Asset](../../Asset.md) > [Equipment](../Equipment.md) > [Electrical_Equipment](.)
# Electrical_Equipment

**Display name:** Electrical Equipment<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Electrical_Equipment;1

---


## Child interfaces
* [Breaker_Panel](Breaker_Panel.md)
* [Bus_Riser](Bus_Riser.md)
* [Disconnect_Switch](Disconnect_Switch.md)
* [Inverter](Inverter.md)
* [Motor_Control_Center](Motor_Control_Center.md)
* [PlugStrip](PlugStrip.md)
* [Switchgear](Switchgear.md)
* [Transformer](Transformer.md)
* [Energy_Storage](Energy_Storage/Energy_Storage.md)

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
