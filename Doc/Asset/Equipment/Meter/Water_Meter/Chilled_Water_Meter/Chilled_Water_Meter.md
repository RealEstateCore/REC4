[Index](../../../../../Index.md) > [Asset](../../../../Asset.md) > [Equipment](../../../Equipment.md) > [Meter](../../Meter.md) > [Water_Meter](../Water_Meter.md) > [Chilled_Water_Meter](#)
# Chilled_Water_Meter

**Display name:** Chilled Water Meter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Chilled_Water_Meter;1

---

## Child interfaces
* [Building_Chilled_Water_Meter](Building_Chilled_Water_Meter.md)

---

## Relationships

### Inherited Relationships
* **[Meter](../../Meter.md):** hasSubMeter, isSubMeterOf, meters
* **[Equipment](../../../Equipment.md):** feeds, isFedBy
* **[Asset](../../../../Asset.md):** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy

---

## Properties

### Inherited Properties
* **[Meter](../../Meter.md):** isVirtualMeter
* **[Equipment](../../../Equipment.md):** operationalStageCount
* **[Asset](../../../../Asset.md):** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight

---

## Target Of
### Inherited
* [Asset](../../../../Asset.md).hasPart
* [Asset](../../../../Asset.md).isPartOf
* [EquipmentCollection](../../../../../Collection/EquipmentCollection.md).includes
* [Loop](../../../../../Collection/Loop/Loop.md).includes
* [System](../../../../../Collection/System/System.md).includes
* [Meter](../../Meter.md).hasSubMeter
* [Meter](../../Meter.md).isSubMeterOf
