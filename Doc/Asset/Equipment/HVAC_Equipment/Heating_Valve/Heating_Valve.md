[Asset](../../../Asset.md) > [Equipment](../../Equipment.md) > [HVAC_Equipment](../HVAC_Equipment.md) > [Heating_Valve](#)
# Heating_Valve

**Display name:** Heating Valve<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Heating_Valve;1

---


## Child interfaces
* [Reheat_Valve](Reheat_Valve.md)
* [Return_Heating_Valve](Return_Heating_Valve.md)
* [Hot_Water_Valve](../../Valve/Water_Valve/Hot_Water_Valve/Hot_Water_Valve.md)

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
