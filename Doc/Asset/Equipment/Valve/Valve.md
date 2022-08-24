[Asset](../../Asset.md) > [Equipment](../Equipment.md) > [Valve](#)
# Valve

**Display name:** Valve<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Valve;1

---


## Child interfaces
* [Gas_Valve](Gas_Valve.md)
* [Natural_Gas_Seismic_Shutoff_Valve](Natural_Gas_Seismic_Shutoff_Valve.md)
* [HVAC_Valve](HVAC_Valve/HVAC_Valve.md)
* [Water_Valve](Water_Valve/Water_Valve.md)

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
