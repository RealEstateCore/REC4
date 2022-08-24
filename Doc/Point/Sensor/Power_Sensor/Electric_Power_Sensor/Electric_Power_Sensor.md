[Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Power_Sensor](../Power_Sensor.md) > [Electric_Power_Sensor](#)
# Electric_Power_Sensor

**Display name:** Electric Power Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Electric_Power_Sensor;1

---


## Child interfaces
* [Active_Power_Sensor](Active_Power_Sensor.md)
* [Peak_Power_Demand_Sensor](Peak_Power_Demand_Sensor.md)
* [Reactive_Power_Sensor](Reactive_Power_Sensor.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
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
