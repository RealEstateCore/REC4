[Asset](../../../../../Asset.md) > [Equipment](../../../../Equipment.md) > [HVAC_Equipment](../../../HVAC_Equipment.md) > [Terminal_Unit](../../Terminal_Unit.md) > [Radiator](../Radiator.md) > [Baseboard_Radiator](.)
# Baseboard_Radiator

**Display name:** Baseboard Radiator<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Baseboard_Radiator;1

---


## Child interfaces
* [Electric_Baseboard_Radiator](../Electric_Radiator/Electric_Baseboard_Radiator.md)
* [Hot_Water_Baseboard_Radiator](../Hot_Water_Radiator/Hot_Water_Baseboard_Radiator.md)
* [Steam_Baseboard_Radiator](../Steam_Radiator/Steam_Baseboard_Radiator.md)

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
