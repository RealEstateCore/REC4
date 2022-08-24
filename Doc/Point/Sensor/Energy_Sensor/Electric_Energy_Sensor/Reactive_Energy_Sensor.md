[Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Energy_Sensor](../Energy_Sensor.md) > [Electric_Energy_Sensor](Electric_Energy_Sensor.md) > [Reactive_Energy_Sensor](#)
# Reactive_Energy_Sensor

**Display name:** Reactive Energy Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Reactive_Energy_Sensor;1

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
