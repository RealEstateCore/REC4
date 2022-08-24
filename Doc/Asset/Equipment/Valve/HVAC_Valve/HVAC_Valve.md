[Asset](../../../Asset.md) > [Equipment](../../Equipment.md) > [Valve](../Valve.md) > [HVAC_Valve](#)
# HVAC_Valve

**Display name:** HVAC Valve<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:HVAC_Valve;1

---


## Child interfaces
* [Chilled_Water_Valve](../Water_Valve/Chilled_Water_Valve.md)
* [Condenser_Water_Valve](../Water_Valve/Condenser_Water_Valve.md)
* [Makeup_Water_Valve](../Water_Valve/Makeup_Water_Valve.md)

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
