[Index](../../../../../../Index.md) > [Point](../../../../../Point.md) > [Setpoint](../../../../Setpoint.md) > [Temperature_Setpoint](../../../Temperature_Setpoint.md) > [Water_Temperature_Setpoint](../../Water_Temperature_Setpoint.md) > [Hot_Water_Temperature_Setpoint](../Hot_Water_Temperature_Setpoint.md) > [Domestic_Hot_Water_Temperature_Setpoint](Domestic_Hot_Water_Temperature_Setpoint.md) > [Leaving_Domestic_Hot_Water_Temperature_Setpoint](#)
# Leaving_Domestic_Hot_Water_Temperature_Setpoint

**Display name:** Leaving Domestic Hot Water Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Leaving_Domestic_Hot_Water_Temperature_Setpoint;1

---

## Relationships

### Inherited Relationships
* **[Point](../../../../../Point.md):** isPointOf

---

## Properties

|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
### Inherited Properties
* **[Point](../../../../../Point.md):** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name

---

## Target Of
### Inherited
* [Asset](../../../../../../Asset/Asset.md).hasPoint
* [EquipmentCollection](../../../../../../Collection/EquipmentCollection.md).hasPoint
* [ActuationEvent](../../../../../../Event/PointEvent/ActuationEvent.md).targetPoint
* [ExceptionEvent](../../../../../../Event/PointEvent/ExceptionEvent.md).sourcePoint
* [ObservationEvent](../../../../../../Event/PointEvent/ObservationEvent.md).sourcePoint
* [ServiceObject](../../../../../../Information/ServiceObject/ServiceObject.md).producedBy
* [Architecture](../../../../../../Space/Architecture/Architecture.md).hasPoint
