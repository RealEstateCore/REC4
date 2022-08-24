[Asset](../../../Asset.md) > [Equipment](../../Equipment.md) > [HVAC_Equipment](../HVAC_Equipment.md) > [Filter](#)
# Filter

**Display name:** Filter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Filter;1

---


## Child interfaces
* [Final_Filter](Final_Filter.md)
* [Intake_Air_Filter](Intake_Air_Filter.md)
* [Mixed_Air_Filter](Mixed_Air_Filter.md)
* [Pre_Filter](Pre_Filter.md)
* [Return_Air_Filter](Return_Air_Filter.md)

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
